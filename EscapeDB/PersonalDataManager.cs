using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace EscapeDB
{

    public static class PersonalDataManager
    {
        
        public static string LocalFolder { get { return Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\DB\").FullName; } }

        public static List<string> GetAvailableLanguages()
        {
            List<string> languages = new List<string>();

            List<string> dirs = Directory.GetDirectories(LocalFolder).ToList();
            foreach (string dir in dirs)
            {
                languages.Add(dir.Replace(LocalFolder, ""));
            }

            return languages;
        }

        public static List<string> GetNames()
        {
            List<string> names = new List<string>();

            return names;
        }

        public static List<PersonalData> GetAvailablePersons()
        {
            List<PersonalData> persons = new List<PersonalData>();

            foreach (string language in GetAvailableLanguages())
            {
                persons.AddRange(GetAvailablePersons(language));
            }

            return persons;
        }

        public static List<PersonalData> GetAvailablePersons(string language)
        {
            List<PersonalData> persons = new List<PersonalData>();

            string root = LocalFolder + "/" + language + "/";
            List<string> dirs = Directory.GetDirectories(root).ToList();

            foreach (string dir in dirs)
                persons.Add(LoadPerson(dir));

            return persons;
        }

        public static PersonalData GetPersonalData(string personName)
        {
            foreach (PersonalData person in GetAvailablePersons())
            {
                if (person.Name == personName)
                    return person;
            }
            return null;
        }

        public static void SavePerson(PersonalData personalData, string language)
        {
            string name = personalData.Name;
            string dir = LocalFolder + "/" + language + "/" + name;

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            List<string> data = new List<string>();

            data.Add("Jméno=" + name);
            data.Add("Věk=" + personalData.Age);
            data.Add("Pohlaví=" + personalData.Sex);
            data.Add("Status=" + personalData.Job);

            if (personalData.Photo != null)
            {
                try
                {
                    personalData.Photo.Save(dir + "/photo.jpg");
                }
                catch { }
            }

            File.WriteAllLines(dir + "/data.txt", data.ToArray());
            File.WriteAllText(dir + "/info.txt", personalData.PersonalInfo);
        }

        public static PersonalData LoadPerson(string folderPath)
        {
            PersonalData person = null;

            if (Directory.Exists(folderPath))
            {
                string name = folderPath.Replace(LocalFolder, "");
                if (File.Exists(folderPath + "/data.txt"))
                {
                    person = new PersonalData();

                    List<string> data = File.ReadAllLines(folderPath + "/data.txt").ToList();

                    foreach (string line in data)
                    {
                        if (line.StartsWith("Jméno="))
                        {
                            person.Name = line.Replace("Jméno=", "");
                        }

                        if (line.StartsWith("Věk="))
                        {
                            person.Age = int.Parse(line.Replace("Věk=", ""));
                        }

                        if (line.StartsWith("Status="))
                        {
                            person.Job = line.Replace("Status=", "");
                        }

                        if (line.StartsWith("Pohlaví="))
                        {
                            person.Sex = line.Replace("Pohlaví=", "");
                        }
                    }

                    if (File.Exists(folderPath + "/info.txt"))
                    {
                        person.PersonalInfo = File.ReadAllText(folderPath + "/info.txt");
                    }

                    if (File.Exists(folderPath + "/photo.jpg"))
                    {
                        person.Photo = Image.FromFile(folderPath + "/photo.jpg");
                    }
                }
            }

            return person;
        }
    }
}