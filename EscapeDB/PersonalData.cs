using System;
using System.Drawing;

namespace EscapeDB
{
    [Serializable]
    public class PersonalData
    {
        public string Language { get; set; } = "EN";
        public string Name { get; set; } = "Mr. Default";
        public int Age { get; set; } = 00;
        public string Job { get; set; } = "Unemployed";
        public string Sex { get; set; } = "Man";
        public string PersonalInfo { get; set; } = "Default person has no data...\n\n no data yet";
        public Image Photo { get; set; }

        public PersonalData()
        {
        }

        public PersonalData(string name, int age, string sex, string job)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Job = job;
        }

        public PersonalData(string name, int age, string sex, string job, string info)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Job = job;
            PersonalInfo = info;
        }

        public PersonalData(string name, int age, string sex, string job, string info, Image imgPhoto)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Job = job;
            PersonalInfo = info;
            Photo = imgPhoto;
        }
    }
}