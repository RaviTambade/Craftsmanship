using System;
using System.Collections.Generic;

// "Don't Call Us, We'll Call You"
namespace HollywoodTest
{
    public class Resume 
    {
        public string Email{get;set;}
        public string Name{get;set;}
        public string Content{get;set;}
  
        public override  string ToString() {

            return "Resume [email=" + Email + ", name=" + Name + ", content=" + Content + "]";
        }
}

    public class JobPortal {
        private static JobPortal portal = new JobPortal();
        private List<Resume> resumeList = new List<Resume>();
        public static JobPortal get(){
            return portal;
        }
        private JobPortal() {}
        public void uploadContent(String mail ,String name,String content)
        {
            Resume resume = new Resume();
            resume.Name=name;
            resume.Email=mail;
            resume.Content=content;
            resumeList.Add(resume);
        }

        public void triggerCampusing(){
            foreach(Resume resume in resumeList)
            {
                Console.WriteLine("Sending mail to " + resume.Name + " at " + resume.Email);
            }
        }
}


    class Program
    {
        static void Main(string[] args)
        {     
            JobPortal.get().uploadContent("ganesh.shinde@gmail.com", "Ganesh Shinde", "A java developer");
            JobPortal.get().uploadContent("Umesh.sharma@gmail.com", "Umesh Sharma", "A PHP developer");
            JobPortal.get().uploadContent("neha.bhor@gmail.com", "Neha Bhor", "A Microservice developer");
            JobPortal.get().uploadContent("adity.ubale@gmail.com", "Aditya Ubale", "A Network engineer");
            JobPortal.get().uploadContent("mayur.kadam@gmail.com", "Mayur Kadam", "A java Architect");   
            // Now trigger campusing
            JobPortal.get().triggerCampusing();
        }
    }
}

/*

When IT Company triggers a campusing, 
the job portal/framework sends the mail to all job seekers who uploaded a CV to Cognizant.
*/
