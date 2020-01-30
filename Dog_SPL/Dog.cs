using System;
using System.Collections.Generic;
using System.Text;

namespace Dog_SPL
{
    public class Dog
    {
        private String name;
        private int age;

        public Dog()
        {
            age = 0;
            name = "";
        }

        public Dog(int age, String name)
        {
            this.setAge(age);
            this.setName(name);
        }

        public int getDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
            return dogYears;
        }

        public int getAge()
        {
            return age;
        }


        public void setAge(int age)
        {
            if (age < 0)
                this.age = 0;
            else
                this.age = age;
        }


        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            bool valid = true;
            char[] n = name.ToCharArray();

            foreach (char c in n)
            {
                if (!Char.IsLetter(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                this.name = name;
            else
                this.name = "";
        }

        public override String ToString()
        {
            return "Dog [age=" + age + ", name=" + name + "]";
        }

    }
}