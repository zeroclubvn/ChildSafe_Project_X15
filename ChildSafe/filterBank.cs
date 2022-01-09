﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildSafe
{
    class filterBank
    {
        List<filter> filterCollection = new List<filter>();
        
        public void InitialFilterBank()
        {
            List<filter> filterCollection = new List<filter>();
            filterCollection.Add(new filter(
                "Steven Black's ad-hoc list filter",
                "Additional sketch domains as Steven Black comes across them.",
                "https://raw.githubusercontent.com/StevenBlack/hosts/master/data/StevenBlack/hosts",
                "occasionally","MIT"));;
            filterCollection.Add(new filter(
                "AdAway",
                "AdAway is an open source ad blocker for Android using the hosts file.",
                "https://raw.githubusercontent.com/AdAway/adaway.github.io/master/hosts.txt",
                "frequently", "CC BY 3.0")); ;
            filterCollection.Add(new filter(
                "Add.2o7Net filter",
                "2o7Net tracking sites based on hostsfile.org content.",
                "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.2o7Net/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Add.Dead filter",
                "Dead sites based on hostsfile.org content.",
                "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Dead/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Add.Risk filter",
                "Risk content sites based on hostsfile.org content.",
                "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Risk/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Add.Spam filter",
                "Spam sites based on hostsfile.org content.",
                "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/add.Spam/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "AdguardTeam cname trackers filter",
                "CNAME-cloaked tracking abuses.",
                "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_disguised_trackers_justdomains.txt",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Mitchell Krog's - Badd Boyz filter",
                "Sketchy domains and Bad Referrers from my Nginx and Apache Bad Bot and Spam Referrer Blockers",
                "https://raw.githubusercontent.com/mitchellkrogza/Badd-Boyz-Hosts/master/hosts",
                "weekly", "MIT")); ;
            filterCollection.Add(new filter(
                "HostsVN filter",
                "Hosts block ads of Vietnamese",
                "https://raw.githubusercontent.com/bigdargon/hostsVN/master/option/hosts-VN",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "KADhosts filter",
                "Fraud/adware/scam websites.",
                "https://raw.githubusercontent.com/PolishFiltersTeam/KADhosts/master/KADhosts.txt",
                "frequently", "CC BY-SA 4.0")); ;
            filterCollection.Add(new filter(
                "MetaMask eth-phishing-detect filter",
                "MetaMask eth-phishing-detect",
                "https://raw.githubusercontent.com/MetaMask/eth-phishing-detect/master/src/hosts.txt",
                "frequently", "MIT")); ;
            filterCollection.Add(new filter(
                "Minecraft-hosts filter",
                "Minecraft related tracker hosts",
                "https://raw.githubusercontent.com/jamiemansfield/minecraft-hosts/master/lists/tracking.txt",
                "occasionally", "CC0-1.0")); ;
            filterCollection.Add(new filter(
                "MVPS filter",
                "The purpose of this site is to provide the user with a high quality custom HOSTS file.",
                "https://winhelp2002.mvps.org/hosts.txt",
                "monthly", "CC BY-NC-SA 4.0")); ;
            filterCollection.Add(new filter(
                "DigitalSide Threat - Intel filter",
                "DigitalSide Threat-Intel malware domains list.",
                "https://raw.githubusercontent.com/davidonzo/Threat-Intel/master/lists/latestdomains.piHole.txt",
                "daily", "MIT")); ;
            filterCollection.Add(new filter(
                "shady-hosts filter",
                "Analytics, ad, and activity monitoring hosts",
                "https://raw.githubusercontent.com/shreyasminocha/shady-hosts/main/hosts",
                "occasionally", "CC0-1.0")); ;
            filterCollection.Add(new filter(
                "Dan Pollock filter",
                "How to make the internet not suck (as much).",
                "https://someonewhocares.org/hosts/zero/hosts",
                "occasionally", "non-commercial with attribution")); ;
            filterCollection.Add(new filter(
                "Tiuxo hostlist - ads filter",
                "Categorized hosts files for DNS based content blocking",
                "https://raw.githubusercontent.com/tiuxo/hosts/master/ads",
                "occasionally", "CC BY 4.0")); ;
            filterCollection.Add(new filter(
                "UncheckyAds filter",
                "Windows installers ads sources sites based on https://unchecky.com/ content.",
                "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/UncheckyAds/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "URLHaus filter",
                "A project from abuse.ch with the goal of sharing malicious URLs.",
                "https://urlhaus.abuse.ch/downloads/hostfile/",
                "occasionally", "CC0")); ;
            filterCollection.Add(new filter(
                "Yoyo filter",
                "Additional sketch domains as I come across them.",
                "https://pgl.yoyo.org/adservers/serverlist.php?hostformat=hosts&mimetype=plaintext&useip=0.0.0.0",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Sinfonietta's gambling blocking hosts filter",
                "Additional sketch domains as I come across them.",
                "https://raw.githubusercontent.com/Sinfonietta/hostfiles/master/gambling-hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Brijrajparmar27 filter",
                "Additional sketch domains as I come across them.",
                "https://raw.githubusercontent.com/brijrajparmar27/host-sources/master/Porn/hosts",
                "occasionally", "CC BY 4.0")); ;
            filterCollection.Add(new filter(
                "Pornhosts filter",
                "Additional sketch domains as I come across them.",
                "https://raw.githubusercontent.com/StevenBlack/hosts/master/extensions/porn/clefspeare13/hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
               "Sinfonietta's porn blocking filter",
               "Additional sketch domains as I come across them.",
               "https://raw.githubusercontent.com/Sinfonietta/hostfiles/master/pornography-hosts",
               "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
                "Sinfonietta's snuff-site blocking filter",
                "Additional sketch domains as I come across them.",
                "https://raw.githubusercontent.com/Sinfonietta/hostfiles/master/snuff-hosts",
                "occasionally", "MIT")); ;
            filterCollection.Add(new filter(
               "Tiuxo hostlist - pornography filter",
               "Additional sketch domains as I come across them.",
               "https://raw.githubusercontent.com/tiuxo/hosts/master/porn",
               "occasionally", "CC BY 4.0")); ;
            filterCollection.Add(new filter(
              "Bon-Appetit porn domain filter",
              "This list is a collection of bunch of domains that relate to adult content, mainly porn websites.",
              "https://raw.githubusercontent.com/Bon-Appetit/porn-domains/master/block.txt",
              "occasionally", "MIT")); ;
            
        }
        
    }
}