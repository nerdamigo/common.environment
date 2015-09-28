using NerdAmigo.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Common.Environment
{
    public class HostNameResolver : IHostNameResolver
    {
		public string GetHostName()
		{
			string dnsHostName = System.Net.Dns.GetHostName();
			string machineName = System.Environment.MachineName;

			string hostName = dnsHostName;
			if (String.IsNullOrEmpty(hostName))
			{
				hostName = machineName;
			}

			return hostName.ToLower();
		}
	}
}
