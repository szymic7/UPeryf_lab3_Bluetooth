using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;
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

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        // Klient bluetooth
        BluetoothClient bluetoothClient;

        // Lista do przechowywania znalezionych pobliskich urzadzen
        List<BluetoothDeviceInfo> foundDevices;

        public Form1()
        {
            while (!IsBluetoothEnabled())
            {
                // Otwarcie ustawień Bluetooth systemu Windows
                System.Diagnostics.Process.Start("ms-settings:bluetooth");
                MessageBox.Show("Please enable Bluetooth on your device and then press OK.", "Bluetooth disabled on the device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            InitializeComponent();
            bluetoothClient = new BluetoothClient();
            foundDevices = new List<BluetoothDeviceInfo>();
            
        }

        public bool IsBluetoothEnabled()
        {
            try
            {
                // Sprzwdzenie, czy urządzenie (komputer) posiada moduł bluetooth
                BluetoothRadio primaryRadio = BluetoothRadio.PrimaryRadio;

                if (primaryRadio == null) return false;
                if (primaryRadio.Mode == RadioMode.PowerOff) return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking Bluetooth status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static Dictionary<Guid, string> BluetoothServiceDictionary = new Dictionary<Guid, string>
        {
            // Communication Services
            { Guid.Parse("00001101-0000-1000-8000-00805f9b34fb"), "Serial Port Service" },
            { Guid.Parse("00001102-0000-1000-8000-00805f9b34fb"), "LAN Access Using PPP" },
            { Guid.Parse("00001103-0000-1000-8000-00805f9b34fb"), "Dialup Networking" },
    
            // Audio and Video Services
            { Guid.Parse("0000110A-0000-1000-8000-00805f9b34fb"), "Audio Source" },
            { Guid.Parse("0000110B-0000-1000-8000-00805f9b34fb"), "Audio Sink" },
            { Guid.Parse("0000110D-0000-1000-8000-00805f9b34fb"), "Advanced Audio Distribution Profile (A2DP)" },
            { Guid.Parse("0000110E-0000-1000-8000-00805f9b34fb"), "Hands-Free" },
            { Guid.Parse("0000110F-0000-1000-8000-00805f9b34fb"), "Headset - Audio Gateway (HSP)" },
            { Guid.Parse("0000111E-0000-1000-8000-00805f9b34fb"), "Handsfree Audio Gateway" },
            { Guid.Parse("0000111F-0000-1000-8000-00805f9b34fb"), "Phonebook Access - PCE (Client)" },
            { Guid.Parse("00001120-0000-1000-8000-00805f9b34fb"), "Phonebook Access - PSE (Server)" },
    
            // OBEX Services
            { Guid.Parse("00001105-0000-1000-8000-00805f9b34fb"), "OBEX Object Push" },
            { Guid.Parse("00001106-0000-1000-8000-00805f9b34fb"), "OBEX File Transfer" },
            { Guid.Parse("00001104-0000-1000-8000-00805f9b34fb"), "OBEX Synchronization Service" },
            { Guid.Parse("00001112-0000-1000-8000-00805f9b34fb"), "OBEX IrMC Synchronization Service" },

            // Remote Control and Gaming
            { Guid.Parse("0000110C-0000-1000-8000-00805f9b34fb"), "Remote Control Target" },
            { Guid.Parse("0000111B-0000-1000-8000-00805f9b34fb"), "SIM Access" },
            { Guid.Parse("00001124-0000-1000-8000-00805f9b34fb"), "Human Interface Device (HID) - Keyboard/Mouse/Gamepad" },
            { Guid.Parse("00001200-0000-1000-8000-00805f9b34fb"), "PnP Information" },
    
            // Health and Fitness Services
            { Guid.Parse("0000180D-0000-1000-8000-00805f9b34fb"), "Heart Rate Service" },
            { Guid.Parse("0000180F-0000-1000-8000-00805f9b34fb"), "Battery Service" },
            { Guid.Parse("00001810-0000-1000-8000-00805f9b34fb"), "Blood Pressure" },
            { Guid.Parse("00001812-0000-1000-8000-00805f9b34fb"), "Human Interface Device (HID) Service" },

            // Device Information and Management
            { Guid.Parse("0000180A-0000-1000-8000-00805f9b34fb"), "Device Information Service" },
            { Guid.Parse("0000112F-0000-1000-8000-00805f9b34fb"), "Basic Imaging Profile (BIP)" },
            { Guid.Parse("00001130-0000-1000-8000-00805f9b34fb"), "Basic Printing Profile (BPP)" },
    
            // Miscellaneous Services
            { Guid.Parse("00001802-0000-1000-8000-00805f9b34fb"), "Immediate Alert" },
            { Guid.Parse("00001803-0000-1000-8000-00805f9b34fb"), "Link Loss" },
            { Guid.Parse("00001804-0000-1000-8000-00805f9b34fb"), "Tx Power" },
            { Guid.Parse("00001805-0000-1000-8000-00805f9b34fb"), "Current Time Service" }
        };


        private void buttonFindDevices_Click(object sender, EventArgs e)
        {
            foundDevices.Clear();
            listBoxDevices.Items.Clear();

            // Szukanie pobliskich urzadzen
            BluetoothDeviceInfo[] devices = bluetoothClient.DiscoverDevices();

            foreach (BluetoothDeviceInfo device in devices)
            {
                foundDevices.Add(device);
                listBoxDevices.Items.Add(device.DeviceName);
            }

            buttonPairDevices.Enabled = false;
        }


        private void findServices(BluetoothDeviceInfo device)
        {
            listBoxServices.Items.Clear();

            // Pobranie dostępnych usług dla wybranego urządzenia
            var services = device.InstalledServices;

            if (services.Length == 0) // Jeśli nie ma dostępnych usług
            {
                MessageBox.Show("No services available on the device.", "No services", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var service in services)
            {
                string translatedService;

                // Jesli usluga wystepuje w slowniku - pobieramy jej nazwe
                if (BluetoothServiceDictionary.TryGetValue(service, out translatedService))
                {
                    listBoxServices.Items.Add(translatedService);
                }
                else
                {
                    listBoxServices.Items.Add("Unknown service");
                }
            }
        }


        private void buttonPairDevices_Click(object sender, EventArgs e)
        {
            if(listBoxDevices.SelectedItem == null)
            {
                MessageBox.Show("Select device to pair.", "Device not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Pobieramy wybrane urządzenie z foundDevices
                BluetoothDeviceInfo selectedDevice = foundDevices[listBoxDevices.SelectedIndex];

                // Sprawdzamy, czy urządzenia są już sparowane
                if (!selectedDevice.Authenticated)
                {
                    bool paired = BluetoothSecurity.PairRequest(selectedDevice.DeviceAddress, "0000");
                    if(paired)
                    {
                        MessageBox.Show("Devices paired successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to pair devices.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Devices are already paired.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                labelPairedDevice.Text = "Paired with: " + selectedDevice.DeviceName;

                // Wyszukanie i wyświetlenie zainstalowanych serwisów bluetooth na sparowanym urządzeniu
                findServices(selectedDevice); 

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured while trying to pair devices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik";
            //openFileDialog.Filter = "Wszystkie pliki (*.*)|*.*";
            openFileDialog.Filter = "Obrazy(*.jpg; *.jpeg; *.png)| *.jpg; *.jpeg; *.png";

            // Sprawdzamy, czy użytkownik wybrał plik i zatwierdził wybór
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Wyświetlamy ścieżkę wybranego pliku w textBoxie
                textBoxFilePath.Text = openFileDialog.FileName;
            }
        }


        private bool IsObexObjectPushSupported(BluetoothDeviceInfo device)
        {
            // Sprawdzenie, czy urządzenie posiada usługę OBEX Object Push
            foreach (Guid service in device.InstalledServices)
            {
                if (service == BluetoothService.ObexObjectPush)
                {
                    return true;
                }
            }
            return false;
        }


        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                MessageBox.Show("Select file to send!", "File not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzamy, czy wybrano urządzenie z listy
            if (listBoxDevices.SelectedItem == null)
            {
                MessageBox.Show("Select destination device to send file to!", "Desination device not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Pobieramy wybrane urządzenie z listy
                BluetoothDeviceInfo selectedDevice = foundDevices[listBoxDevices.SelectedIndex];

                // Sprawdzamy, czy urządzenie docelowe posiada usługę OBEX Object Push
                if (!IsObexObjectPushSupported(selectedDevice))
                {
                    MessageBox.Show("Selected device does not support OBEX Object Push. File transfer cannot be performed.", "Unsupported Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Żądanie OBEX do wysłania pliku
                Uri uri = new Uri("obex://" + selectedDevice.DeviceAddress + "/" + System.IO.Path.GetFileName(textBoxFilePath.Text));
                ObexWebRequest request = new ObexWebRequest(uri);
                request.ReadFile(textBoxFilePath.Text);

                // Wysłanie pliku
                /*ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                MessageBox.Show("File sent successfully. Response status: " + response.StatusCode, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                response.Close();*/
                using (ObexWebResponse response = (ObexWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == ObexStatusCode.OK)
                    {
                        MessageBox.Show("File sent successfully. Response status: " + response.StatusCode, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File not sent. Response status: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while sending file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDevices.SelectedIndex == -1)
            {
                buttonPairDevices.Enabled = false;
            }
            else
            {
                buttonPairDevices.Enabled = true;
            }
        }
    }
}
