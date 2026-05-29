using System.Collections;

namespace demo
{
    public class respond
    {
        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor

            answers(reply);
            words(ignore);


        }//end of constructor

        //method to store the list of words
        private void words(ArrayList ignoring)
        {//
         //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }// end of method word 




        public void answers(ArrayList add_answers)
        {//start of method




            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");


            add_answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");


            add_answers.Add("cybersecurity cybersecurity is about protecting systems and networks from digital threats.");
            add_answers.Add("Cybersecurity is the practice of protecting your digital devices, networks, and personal information from theft, damage, or unauthorized access." +
                "Think of it as the digital equivalent of locking your doors and windows—it’s a set of tools, habits, and safeguards designed to keep the wrong people out of your online life." +
                "While many people imagine sophisticated hackers breaking through complex code, the reality is far simpler: most cyberattacks are opportunistic and target easy mistakes." +
                " That’s why cybersecurity isn’t just about software; it’s equally about your daily behavior, such as recognizing suspicious messages, using strong passwords, and keeping apps updated.");
            add_answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            add_answers.Add("cybersecurity it focuses on securing digital information and systems.");
            add_answers.Add("");


            add_answers.Add("phishing phishing is a scam where attackers pretend to be trusted sources to steal information.");
            add_answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            add_answers.Add("phishing attackers use deception to make users believe they are legitimate.");
            add_answers.Add("Phishing is a type of cyberattack where a scammer pretends to be a trusted person, company, or organization to trick you into revealing sensitive information, such as your passwords, credit card numbers, or bank account details. " +
                "These attacks almost always arrive in the form of an email, text message, or direct message that appears legitimate, often using fake logos, urgent language, or threats like \"your account will be closed\" to create panic. " +
                "The message typically contains a link that leads to a fake website designed to steal your login credentials, or an attachment that installs malware on your device. " +
                "For example, you might receive an email that looks exactly like it's from your bank, asking you to \"verify your account\" by clicking a link and entering your username and password—but the website is a copycat controlled by the attacker." +
                " The best defense against phishing is to slow down, inspect the sender's email address closely (it often has small misspellings), avoid clicking links in unexpected messages, and never enter personal information after arriving from a link sent to you. " +
                "When in doubt, contact the company or person directly using a phone number or website you know is real, not the contact information provided in the suspicious message.");
            add_answers.Add("Phishing is by far the most widespread cyber attack, and it targets you directly rather than your computer." +
                " In a phishing attack, the attacker sends a fake email, text message, or direct message pretending to be a legitimate company like your bank, a delivery service, or even a coworker." +
                " The message usually creates urgency—\"Your account will be closed in 24 hours\"—and tricks you into clicking a malicious link or downloading an infected attachment. " +
                "Once you click, you may be sent to a fake login page that steals your password, or malware installs silently on your device." +
                " Phishing works because it exploits human nature, not technical flaws, which is why it remains the number one threat to individuals and organizations alike." +
                "\r\n\r\nMalware is a broad category that includes viruses, worms, spyware, and trojans. Malware is malicious software designed to damage, disrupt, or gain unauthorized access to your device. " +
                "You typically get infected by clicking a bad link, downloading an infected file, or using an infected USB drive. Once installed, malware can do many things: delete your files, steal your passwords, record your keystrokes," +
                " or turn your computer into a zombie that attacks other systems without your knowledge.\r\n\r\nRansomware is a particularly nasty form of malware that has become extremely common in recent years. " +
                "When ransomware infects your computer, it encrypts all your personal files—documents, photos, videos—making them completely inaccessible. The attacker then displays a message demanding payment, " +
                "usually in cryptocurrency like Bitcoin, in exchange for the decryption key. Even if you pay, there is no guarantee you will get your files back. Ransomware often spreads through phishing emails or by exploiting outdated software, " +
                "which is why keeping backups of your important files on a separate drive or cloud service is critical.\r\n\r\nMan-in-the-Middle (MitM) attacks occur when an attacker secretly intercepts communication between two parties, " +
                "such as between you and your bank's website. This often happens on unsecured public Wi-Fi networks, like those in coffee shops or airports. The attacker can read your messages, steal login credentials, or even alter the information being sent without either side knowing. " +
                "Using a VPN (Virtual Private Network) and avoiding sensitive activities on public Wi-Fi are the best protections against this type of attack.\r\n\r\nDenial-of-Service (DoS) and Distributed Denial-of-Service (DDoS) attacks aim to make a website or online service unavailable by flooding it with so much fake traffic that it crashes under the load." +
                " While these attacks usually target companies, not individual users, you can experience the effects when your favorite website or online game becomes slow or completely unreachable. Attackers often use networks of infected computers (called botnets) to launch these massive attacks.\r\n\r\nPassword attacks come in several forms, " +
                "but all share the same goal: gaining access to your accounts by cracking or stealing your password. In a brute force attack, automated software tries millions of password combinations until it finds the right one. In credential stuffing, attackers take passwords leaked from one data breach and try them on other websites," +
                " betting that you reuse the same password everywhere. This is why using unique, strong passwords for each account and enabling multi-factor authentication (MFA) is so important.\r\n\r\nSQL Injection attacks target websites and databases rather than individual users directly. When a website has poor security, an attacker can type specially crafted commands into a search box " +
                "or login form that tricks the website's database into revealing its contents. This can expose massive amounts of user data, including passwords, credit card numbers, and personal messages. As a user, you cannot prevent SQL injection directly, but you can protect yourself by using unique passwords and monitoring your accounts for suspicious activity after a company announces a data breach." +
                "\r\n\r\nZero-day attacks exploit security vulnerabilities that the software maker does not yet know about, meaning there is no fix available at the time of the attack. These are highly valued by sophisticated attackers and are often used in targeted attacks against governments, large corporations, or high-value individuals. " +
                "For the average user, the best defense is to enable automatic updates on all software—when a fix is eventually released, you want it installed immediately.");



            add_answers.Add("firewall a firewall controls network traffic based on security rules.");
            add_answers.Add("firewall it helps block unwanted access to your device or network.");
            add_answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");


            add_answers.Add("password a password is used to secure access to your accounts or devices.");
            add_answers.Add("password it should be strong, long and not easy to guess.");
            add_answers.Add("password avoid using personal details when creating one.");


            add_answers.Add("hacked account immediately secure your account and log out of all devices.");
            add_answers.Add("hacked account contact support if your account has been compromised.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");


            add_answers.Add("fraud contact your bank immediately if fraud is detected.");
            add_answers.Add("fraud report suspicious financial activity to the authorities.");
            add_answers.Add("fraud monitor your accounts for unusual activity.");


            add_answers.Add("malicious chatbot malicious bots often create urgency to trick users.");
            add_answers.Add("malicious chatbot fake chatbots may ask for sensitive information.");
            add_answers.Add("malicious chatbot be cautious if a bot pressures you for personal data.");


            add_answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            add_answers.Add("vpn it encrypts your internet traffic for safety.");
            add_answers.Add("vpn it improves security when using public networks.");




            //sentiment detection

            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");


            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");


            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");


            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");


            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");


            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");





        }//end of method








    }//end of the respond class
}//end os namespace 
