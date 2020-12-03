using System;

namespace Valid_Usernames_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] password = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            char[] passwordCharacters = new char[] { };

            for (int i = 0; i < password.Length; i++)
            {
                
               
                    passwordCharacters = password[i].ToCharArray();
                if (passwordCharacters.Length>3 && passwordCharacters.Length<16)
                {
                    bool flag = true;
                    for (int l = 0; l < passwordCharacters.Length; l++)
                    {

                        if (
                            ((int)passwordCharacters[l] >= 48 && (int)passwordCharacters[l] <= 57) ||
                            ((int)passwordCharacters[l] >= 97 && (int)passwordCharacters[l] <= 122) ||
                            ((int)passwordCharacters[l] >= 65 && (int)passwordCharacters[l] <= 90)
                            )
                        {
                            continue;
                        }
                        else if (passwordCharacters[l]=='-' || passwordCharacters[l]=='_')
                        {
                            continue;
                        }else
                        {
                            flag = false;
                            break;
                        }

                         
                    }
                    if (flag)
                    {
                        Console.WriteLine(password[i]);
                    }
                   
                }
                
                
            }
            
        }
    }
}
