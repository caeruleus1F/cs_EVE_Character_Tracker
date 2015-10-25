/*
 * Program: EVE Online Character Tracker
 * Author: Garrett Bates
 * IGN: Thirtyone Organism
 * Last Mod: October 24, 2015
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;
using System.Reflection;

namespace cs_EVE_Character_Tracker
{
    public partial class Form1 : Form
    {
        WebClient _webTraining31 = new WebClient();
        WebClient _webWallet31 = new WebClient();

        WebClient _webTraining32 = new WebClient();
        WebClient _webWallet32 = new WebClient();

        WebClient _webTrainingFThis = new WebClient();
        WebClient _webWalletFThis = new WebClient();

        List<string> _listOfTypeIDs;

        Uri _walletEndpoint31Uri = new Uri("https://api.eveonline.com/char/AccountBalance.xml.aspx?&characterID=91810030&keyID=3890775&vCode=8w2EoSi0UyXXiSaagZnUN1ep2B6bkcFFCNd5CBsMnE7X5CHB3iHqYxEGubzBWP3c");
        Uri _walletEndpoint32Uri = new Uri("https://api.eveonline.com/char/AccountBalance.xml.aspx?&characterID=91995291&keyID=3033583&vCode=arLeZxr9AUImT3WGVOtOsMh3hTTjhginXFpu429WIcohRRKQPtJddSHZEnDdNmxq");
        Uri _walletEndpointFThisUri = new Uri("https://api.eveonline.com/char/AccountBalance.xml.aspx?&characterID=1042504230&keyID=3033615&vCode=Cz8RmzKhGbTNqGxlc55ERETVQyRIs9tLsABySu1G7irkVPFjsErR8IOaYffsBxTw");
        
        Uri _trainingEndpoint31Uri = new Uri("https://api.eveonline.com/char/SkillInTraining.xml.aspx?&characterID=91810030&keyID=3890775&vCode=8w2EoSi0UyXXiSaagZnUN1ep2B6bkcFFCNd5CBsMnE7X5CHB3iHqYxEGubzBWP3c");
        Uri _trainingEndpoint32Uri = new Uri("https://api.eveonline.com/char/SkillInTraining.xml.aspx?&characterID=91995291&keyID=3033583&vCode=arLeZxr9AUImT3WGVOtOsMh3hTTjhginXFpu429WIcohRRKQPtJddSHZEnDdNmxq");
        Uri _trainingEndpointFThisUri = new Uri("https://api.eveonline.com/char/SkillInTraining.xml.aspx?&characterID=1042504230&keyID=3033615&vCode=Cz8RmzKhGbTNqGxlc55ERETVQyRIs9tLsABySu1G7irkVPFjsErR8IOaYffsBxTw");

        int _interval = 8 * 3600 * 1000; 

        public Form1()
        {
            InitializeComponent();

            timerAPICall.Interval = _interval;
            timerAPICall.Enabled = false;

            _webTraining31.Proxy = null;
            _webTraining31.DownloadStringCompleted += _webTraining31_DownloadStringCompleted;
            _webTraining32.Proxy = null;
            _webTraining32.DownloadStringCompleted += _webTraining32_DownloadStringCompleted;
            _webTrainingFThis.Proxy = null;
            _webTrainingFThis.DownloadStringCompleted += _webTrainingFThis_DownloadStringCompleted;
            _webWallet31.Proxy = null;
            _webWallet31.DownloadStringCompleted += _webWallet31_DownloadStringCompleted;
            _webWallet32.Proxy = null;
            _webWallet32.DownloadStringCompleted += _webWallet32_DownloadStringCompleted;
            _webWalletFThis.Proxy = null;
            _webWalletFThis.DownloadStringCompleted += _webWalletFThis_DownloadStringCompleted;

            LoadTypeIDs();
        }

        /*
         * Loads each line containing TypeIDs and TypeNames from the
         * embedded resources file.
         */
        private void LoadTypeIDs()
        {
            try
            {
                _listOfTypeIDs = Properties.Resources.invTypes_Vanguard.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        /*
         * Takes the TypeID number associated with the skill that the character
         * is training and translates it into a TypeName.
         */
        private string GetSkillName(int typeID)
        {
            int index = BinarySearch(typeID);
            string skill_name = "N/A";

            if (index != -1)
            {
                skill_name = _listOfTypeIDs[index].Split(',')[1];
            }

            return skill_name;
        }

        /*
         * Binary search algo used to find the index value containing the
         * desired TypeName.
         */
        private int BinarySearch (int typeID)
        {
            int left = 0;
            int right = _listOfTypeIDs.Count;
            int mid = (left + right) / 2;
            int current_typeID = 0;
            int return_value = -1;

            try
            {
                while (left <= right &&
                    current_typeID != typeID)
                {
                    current_typeID = Convert.ToInt32(_listOfTypeIDs[mid].Split(',')[0]);

                    if (current_typeID > typeID)
                    {
                        right = mid - 1;
                        mid = (left + right) / 2;
                    }
                    else if (current_typeID < typeID)
                    {
                        left = mid + 1;
                        mid = (left + right) / 2;
                    }
                    else if (current_typeID == typeID)
                    {
                        return_value = mid;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return return_value;
        }
        
        /*
         * Handles the onClick event for btnQuery.
         */
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryServer();
        }

        /*
         * This is the main method called when the user clicks the 'Query'
         * button. Subsequent calls originate from the timer.
         */
        private void QueryServer()
        {
            try
            {
                _webWallet31.DownloadStringAsync(_walletEndpoint31Uri);
                _webTraining31.DownloadStringAsync(_trainingEndpoint31Uri);
                _webWallet32.DownloadStringAsync(_walletEndpoint32Uri);
                _webTraining32.DownloadStringAsync(_trainingEndpoint32Uri);
                _webWalletFThis.DownloadStringAsync(_walletEndpointFThisUri);
                _webTrainingFThis.DownloadStringAsync(_trainingEndpointFThisUri);
                txbStatus.Text = "Last attempt: " + DateTime.Now.ToShortDateString()
                    + " " + DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {
                txbStatus.Text = "Can't get data for some reason";
                txbNextPull.Text = "Error reaching server.";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses the balance value and outputs it to the relevant textbox.
         */
        void _webWalletFThis_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            decimal balance = 0.0M;

            try
            {
                xmldoc.LoadXml(e.Result);
                balance = Convert.ToDecimal(xmldoc.SelectSingleNode("/eveapi/result/rowset/row").Attributes[2].Value);
                txbWalletFThis.Text = balance.ToString("N2");
            }
            catch (Exception ex)
            {
                txbStatus.Text = "Exception: Endpoint could not be reached.";
                txbWalletFThis.Text = "N/A";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses the balance value and outputs it to the relevant textbox.
         */
        void _webWallet32_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            decimal balance = 0.0M;

            try
            {
                xmldoc.LoadXml(e.Result);
                balance = Convert.ToDecimal(xmldoc.SelectSingleNode("/eveapi/result/rowset/row").Attributes[2].Value);
                txbWallet32.Text = balance.ToString("N2");
            }
            catch (Exception ex)
            {
                txbStatus.Text = "Exception: Endpoint could not be reached.";
                txbWallet32.Text = "N/A";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses the balance value and outputs it to the relevant textbox.
         */
        void _webWallet31_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            decimal balance = 0.0M;

            try
            {
                xmldoc.LoadXml(e.Result);
                balance = Convert.ToDecimal(xmldoc.SelectSingleNode("/eveapi/result/rowset/row").Attributes[2].Value);
                txbWallet31.Text = balance.ToString("N2");
            }
            catch (Exception ex)
            {
                txbStatus.Text = "Exception: Endpoint could not be reached.";
                txbWallet31.Text = "N/A";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses skill and level being trained and completion time.
         * Timer interval for all 6 WebClient instances is determined by
         * the currentTime and cachedUntil values contained in the XML file
         * associated with Thirtyone Organism's relevant server response.
         */
        void _webTrainingFThis_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            DateTime endTime;
            int skillTypeID = 0;
            string skillTypeName = null;
            string skillLevel = null;

            try
            {
                xmldoc.LoadXml(e.Result);
                endTime = Convert.ToDateTime(xmldoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skillTypeID = Convert.ToInt32(xmldoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skillTypeName = GetSkillName(skillTypeID);
                skillLevel = xmldoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText;

                sb.Append(skillTypeName).Append(" ").Append(", Rank ").Append(skillLevel);
                txbSkillFThis.Text = sb.ToString();
                sb.Clear();
                sb.Append(endTime.ToLocalTime().ToLongDateString()).Append(" at ")
                    .Append(endTime.ToLocalTime().ToLongTimeString());
                txbTrainingFThis.Text = sb.ToString();
            }
            catch (Exception)
            {
                txbSkillFThis.Text = "Skill queue empty.";
                txbTrainingFThis.Text = "N/A";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses skill and level being trained and completion time.
         * Timer interval for all 6 WebClient instances is determined by
         * the currentTime and cachedUntil values contained in the XML file
         * associated with Thirtyone Organism's relevant server response.
         */
        void _webTraining32_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            DateTime endTime;
            int skillTypeID = 0;
            string skillTypeName = null;
            string skillLevel = null;

            try
            {
                xmldoc.LoadXml(e.Result);
                endTime = Convert.ToDateTime(xmldoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skillTypeID = Convert.ToInt32(xmldoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skillTypeName = GetSkillName(skillTypeID);
                skillLevel = xmldoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText;

                sb.Append(skillTypeName).Append(" ").Append(", Rank ").Append(skillLevel);
                txbSkill32.Text = sb.ToString();
                sb.Clear();
                sb.Append(endTime.ToLocalTime().ToLongDateString()).Append(" at ")
                    .Append(endTime.ToLocalTime().ToLongTimeString());
                txbTraining32.Text = sb.ToString();
            }
            catch (Exception)
            {
                txbSkill32.Text = "Skill queue empty.";
                txbTraining32.Text = "N/A";
            }
        }

        /*
         * Calls to the EVE Online API endpoint are made asyncronously.
         * This function handles the DownloadStringCompleted event.
         * Parses skill and level being trained and completion time.
         * Timer interval for all 6 WebClient instances is determined by
         * the currentTime and cachedUntil values contained in the XML file
         * associated with Thirtyone Organism's relevant server response.
         */
        void _webTraining31_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            DateTime endTime;
            int skillTypeID = 0;
            string skillTypeName = null;
            string skillLevel = null;
            DateTime currentTime;
            DateTime cachedUntil;
            // set a default timer interval of 8 hours, in milliseconds

            try
            {
                xmldoc.LoadXml(e.Result);
                endTime = Convert.ToDateTime(xmldoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skillTypeID = Convert.ToInt32(xmldoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skillTypeName = GetSkillName(skillTypeID);
                skillLevel = xmldoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText;

                sb.Append(skillTypeName).Append(" ").Append(", Rank ").Append(skillLevel);
                txbSkill31.Text = sb.ToString();
                sb.Clear();
                sb.Append(endTime.ToLocalTime().ToLongDateString()).Append(" at ")
                    .Append(endTime.ToLocalTime().ToLongTimeString());
                txbTraining31.Text = sb.ToString();

                currentTime = Convert.ToDateTime(xmldoc.SelectSingleNode("/eveapi/currentTime").InnerText);
                cachedUntil = Convert.ToDateTime(xmldoc.SelectSingleNode("/eveapi/cachedUntil").InnerText);
                _interval = Convert.ToInt32(cachedUntil.Subtract(currentTime).TotalMilliseconds) + 5000;

                timerAPICall.Interval = _interval;
                timerAPICall.Enabled = true;

                cachedUntil.AddMilliseconds(_interval);
                sb.Clear();
                sb.Append("Next attempt: ")
                    .Append(cachedUntil.ToLocalTime().ToLongDateString()).Append(" at ")
                    .Append(cachedUntil.ToLocalTime().ToLongTimeString());
                txbNextPull.Text = sb.ToString();
                sb.Clear();
            }
            catch (Exception)
            {
                txbSkill31.Text = "Skill queue empty.";
                txbTraining31.Text = "N/A";
            }
        }

        /*
         * Handles the timer tick event.
         */
        private void timerAPICall_Tick(object sender, EventArgs e)
        {
            QueryServer();
        }

    }
}
