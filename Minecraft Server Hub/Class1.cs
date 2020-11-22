using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Nat;

namespace Minecraft_Server_Hub
{
    public class PortForward
    {
        public static int port;
        public PortForward()
        {
            NatUtility.DeviceFound += DeviceFound;
            NatUtility.DeviceLost += DeviceLost;
            NatUtility.StartDiscovery();
        }

        private void DeviceFound(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;
            device.CreatePortMap(new Mapping(Protocol.Tcp, port, port));
            // on device found code
        }

        private void DeviceLost(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;
            device.DeletePortMap(new Mapping(Protocol.Tcp, port, port));
            // on device disconnect code
        }
    }
}
