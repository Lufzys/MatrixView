using MatrixView.Classes.Models;
using MatrixView.Forms.Design;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixView.Classes;
using MatrixView.Classes.Variables;
using RestSharp;
using static LCU.LCU;
using static MatrixView.Classes.Models.Lobby;

namespace MatrixView.Forms
{
    public partial class MainForm : Form
    {
        DragObj Drag;
        public MainForm()
        {
            InitializeComponent();
            Drag = new DragObj(this, plTop);
            this.Opacity = 0.0;
        }

        private static bool CanUpdate = true;
        private void MainForm_Load(object sender, EventArgs e)
        {
            Aero.ChangeAccent(this.Handle, new Classes.Variables.Structs.AccentPolicy { AccentState = Classes.Variables.Enums.AccentState.ACCENT_ENABLE_HOSTBACKDROP }, true);
            flpItems.AutoScroll = false;
            btnAutoAccept.CheckedState.FillColor = Color.FromArgb(30, 233, 194, 111);
            btnAutoAccept.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAutoSkinBoost.CheckedState.FillColor = Color.FromArgb(30, 233, 194, 111);
            btnAutoSkinBoost.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAppearChangeStatus.CheckedState.FillColor = Color.FromArgb(30, 233, 194, 111);
            btnAppearChangeStatus.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            #region HIDE SCROLLBARS https://stackoverflow.com/questions/5489273/how-do-i-disable-the-horizontal-scrollbar-in-a-panel
            flpItems.HorizontalScroll.Maximum = 0;
            flpItems.VerticalScroll.Maximum = 0;
            flpItems.AutoScroll = false;
            flpItems.VerticalScroll.Visible = false;
            flpItems.HorizontalScroll.Visible = false;
            flpItems.AutoScroll = true;
            #endregion
            FadeShow.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            FadeHide.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
        }

        private void cbStreamproof_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStreamproof.Checked)
            {
                WinAPI.SetWindowDisplayAffinity(this.Handle, Enums.DisplayAffinity.Monitor);
            }
            else
            {
                WinAPI.SetWindowDisplayAffinity(this.Handle, Enums.DisplayAffinity.None);
            }
        }

        private void btnSkinBoost_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            tRequest gameflow = Request(RestSharp.Method.GET, "/lol-gameflow/v1/gameflow-phase");
            if (gameflow.IsAvaible())
            {
                if (gameflow.Content.Contains("ChampSelect"))
                {
                    tRequest teamBoostRequest = Request(RestSharp.Method.GET, "/lol-champ-select/v1/team-boost");
                    if (teamBoostRequest.IsAvaible())
                    {
                        TeamBoost.Root teamBoost = JsonConvert.DeserializeObject<TeamBoost.Root>(teamBoostRequest.Content);
                        if (teamBoost.SummonerId == -1)
                        {
                            char quote = (char)34;
                            string postUrl = "/lol-login/v1/session/invoke?destination=lcdsServiceProxy&method=call&args=[" + quote + quote + "," + quote + "teambuilder-draft" + quote + "," + quote + "activateBattleBoostV1" + quote + "," + quote + quote + "]";
                            Request(RestSharp.Method.POST, postUrl);
                        }
                        else
                        {
                            MessageBox.Show("Already boosted!", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You are not in Champion Selection phase", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Network error?", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPratice5v5_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            var lobby = new CustomLobby // Thanks leftspace89 <3 https://github.com/leftspace89/LeaguePW5/blob/915e3aacb050de799cbb3ba45605c1d36a165fb4/LeaguePW5.cs#L93
            {
                isCustom = true,
                customGameLobby = new CustomGameLobby
                {
                    lobbyName = "Matrix View - Practice",
                    lobbyPassword = "",
                    configuration = new Configuration
                    {
                        gameMode = "PRACTICETOOL",
                        gameMutator = "",
                        gameServerRegion = "",
                        mapId = 11,
                        mutators = new Mutators { id = 1 },
                        spectatorPolicy = "AllAllowed",
                        teamSize = 5
                    }
                }
            };

            LCU.LCU.tRequest lobbyReq = LCU.LCU.Request(RestSharp.Method.POST, "/lol-lobby/v2/lobby", lobby, RestSharp.DataFormat.Json);
        }

        private void btnAppearChangeStatus_Click(object sender, EventArgs e)
        {
            if(!btnAppearChangeStatus.Checked)
            {
                btnAppearChangeStatus.Text = "Appear as Offline";
            }
            else
            {
                btnAppearChangeStatus.Text = "Appear as Online";
            }
        }

        private void btnChangeProfileIcon_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            try
            {
                int profileInput = Convert.ToInt32(Interaction.InputBox("Write Profile Icon Id!", "Matrix View", "29", Screen.PrimaryScreen.Bounds.Width / 2 - 200, Screen.PrimaryScreen.Bounds.Height / 2 - 100));
                Request(RestSharp.Method.PUT, "/lol-summoner/v1/current-summoner/icon", new { profileIconId = profileInput }, RestSharp.DataFormat.Json);
            }
            catch
            {
                MessageBox.Show("Wrong Input!", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLobbyCrash_Click(object sender, EventArgs e) // ty shunre & aful <3 <3 <3
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            tRequest gameflow = Request(RestSharp.Method.GET, "/lol-gameflow/v1/gameflow-phase");
            if (gameflow.IsAvaible())
            {
                if (gameflow.Content.Contains("ChampSelect")) 
                {
                    Request(Method.DELETE, "/lol-lobby/v2/lobby");
                    Request(Method.POST, "/lol-lobby/v2/matchmaking/quick-search", new {queueId = 1110}, // maybe you ask "queue id why 1110?". Answer = https://static.developer.riotgames.com/docs/lol/queues.json
                        DataFormat.Json);
                }
                else
                {
                    MessageBox.Show("You are not in Champion Selection phase", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Network error?", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateClashLobby_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            Request(Method.POST, "/lol-lobby/v2/lobby", new { queueId = 700 }, DataFormat.Json);
        }

        private void btnFreeContent_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
                return;

            if (!CheckParams())
                return;

            if (!AccountFounded)
                return;

            if (!Request(Method.POST,
                    "/lol-login/v1/session/invoke?destination=inventoryService&method=giftFacebookFan&args=[]")
                .IsAvaible())
            {
                MessageBox.Show("Error", "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool AccountFounded = false;
        private void Update_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LeagueClientUx").Length == 0)
            {
                if(AccountFounded)
                {
                    AccountFounded = false;
                    MessageBox.Show("Account Log Out : " + tbUsernameReadonly.Text, "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUsernameReadonly.Text = "MATRIX_USER";
                    pbLevelProgress.Value = 0;
                    pbPlayerIcon.ImageLocation = string.Empty;
                }
                return;
            }

            if (!CheckParams())
                return;

            if (Drag.MouseDown)
                return;

            tRequest currentSummonerReq = Request(RestSharp.Method.GET, "/lol-summoner/v1/current-summoner");
            if(currentSummonerReq.IsAvaible())
            {
                CurrentSummoner.Root currentSummoner = JsonConvert.DeserializeObject<CurrentSummoner.Root>(currentSummonerReq.Content);
                tbUsernameReadonly.Text = currentSummoner.DisplayName;
                pbLevelProgress.Value = currentSummoner.PercentCompleteForNextLevel;
                pbPlayerIcon.ImageLocation = "https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/profile-icons/" + currentSummoner.ProfileIconId+ @".jpg";
                if (!AccountFounded)
                {
                    AccountFounded = true;
                    MessageBox.Show("Account Log In : " + tbUsernameReadonly.Text, "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(btnAutoAccept.Checked)
                    {
                        tRequest readyReq = Request(RestSharp.Method.GET, "/lol-matchmaking/v1/ready-check");
                        if (readyReq.IsAvaible())
                        {
                            ReadyCheck.Root readyCheck = JsonConvert.DeserializeObject<ReadyCheck.Root>(readyReq.Content);
                            if (readyCheck.State == "InProgress")
                            {
                                Request(RestSharp.Method.POST, "/lol-matchmaking/v1/ready-check/accept");
                            }
                        }
                    }

                    if(btnAutoSkinBoost.Checked)
                    {
                        tRequest gameflow = Request(RestSharp.Method.GET, "/lol-gameflow/v1/gameflow-phase");
                        if (gameflow.IsAvaible())
                        {
                            if (gameflow.Content.Contains("ChampSelect"))
                            {
                                tRequest teamBoostRequest = Request(RestSharp.Method.GET, "/lol-champ-select/v1/team-boost");
                                if (teamBoostRequest.IsAvaible())
                                {
                                    TeamBoost.Root teamBoost = JsonConvert.DeserializeObject<TeamBoost.Root>(teamBoostRequest.Content);
                                    if (teamBoost.SummonerId == -1)
                                    {
                                        char quote = (char)34;
                                        string postUrl = "/lol-login/v1/session/invoke?destination=lcdsServiceProxy&method=call&args=[" + quote + quote + "," + quote + "teambuilder-draft" + quote + "," + quote + "activateBattleBoostV1" + quote + "," + quote + quote + "]";
                                        Request(RestSharp.Method.POST, postUrl);
                                    }
                                }
                            }
                        }
                    }

                    if(btnAppearChangeStatus.Checked)
                    {
                        tRequest chatReq = Request(RestSharp.Method.GET, "/lol-chat/v1/me");
                        if (chatReq.IsAvaible())
                        {
                            Chat.Root chat = JsonConvert.DeserializeObject<Chat.Root>(chatReq.Content);
                            if(chat.Availability != "offline")
                            {
                                Chat.Root chatPut = new Chat.Root();
                                chatPut.Availability = "offline";
                                Request(RestSharp.Method.PUT, "/lol-chat/v1/me", JsonConvert.SerializeObject(chatPut), RestSharp.DataFormat.Json);
                            }
                        }
                    }
                    else
                    {
                        tRequest chatReq = Request(RestSharp.Method.GET, "/lol-chat/v1/me");
                        if (chatReq.IsAvaible())
                        {
                            Chat.Root chat = JsonConvert.DeserializeObject<Chat.Root>(chatReq.Content);
                            if (chat.Availability == "offline")
                            {
                                Chat.Root chatPut = new Chat.Root();
                                chatPut.Availability = "chat";
                                Request(RestSharp.Method.PUT, "/lol-chat/v1/me", JsonConvert.SerializeObject(chatPut), RestSharp.DataFormat.Json);
                            }
                        }
                    }
                }
            } else
            {
                if(AccountFounded)
                {
                    AccountFounded = false;
                    MessageBox.Show("Account Log Out : " + tbUsernameReadonly.Text, "Matrix View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbUsernameReadonly.Text = "MATRIX_USER";
                pbLevelProgress.Value = 0;
                pbPlayerIcon.ImageLocation = string.Empty;
            }
        }

        private void FadeShow_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
            if(this.Opacity >= 1.0)
            {
                Update.Start();
                FadeShow.Stop();
            }
        }

        private void FadeHide_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.07;
            if (this.Opacity <= 0.0)
            {
                Environment.Exit(0);
            }
        }
    }
}
