using System;
using System.IO.Ports;
using System.Threading;

namespace ScaleServiceStackConsole.ServiceInterface
{
    public class PortChat
    {
        static bool _continue;
        static SerialPort _serialPort;

        public static void Data()
        {
            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();

            // TODO: Stop reading scale here

            while (_continue)
            {
                if(stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    _serialPort.WriteLine(String.Format("<{0}>: {1}", name, message));
                }
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }

        // Display Port values and prompt user to enter a port



    }
}
