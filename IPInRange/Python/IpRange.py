import socket
import struct
from sys import argv

scriptFile , minIpString, maxIpString, ipString  = argv

def GetIntIpFromString(stringIP):
        return struct.unpack("!L",socket.inet_aton(stringIP))[0]

minIp = GetIntIpFromString(minIpString)
maxIp = GetIntIpFromString(maxIpString)
ip    = GetIntIpFromString(ipString)


if (minIp <= ip  and  maxIp >= ip) :
        print(ipString + " lies in range.")
else:
        print(ipString  + " dosen't lies in range.")
