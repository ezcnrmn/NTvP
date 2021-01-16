﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Класс AboutForm.
    /// </summary>
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ezcnrmn/NTvP");
        }

        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("leonid.volkov99@gmail.com");
        }

        private void AboutForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Close();
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.SuppressKeyPress = true;
            }
        }
    }
}
