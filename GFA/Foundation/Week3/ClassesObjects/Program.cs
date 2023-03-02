/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week3.ClassesObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///*
            // PostIt Objects
            PostIt post1 = new PostIt();
            post1.BackgroundColor = "orange";
            post1.Text = "Idea 1";
            post1.TextColor = "blue";

            PostIt post2 = new PostIt();
            post2.BackgroundColor = "pink";
            post2.Text = "Awesome";
            post2.TextColor = "black";

            PostIt post3 = new PostIt();
            post3.BackgroundColor = "yellow";
            post3.Text = "Superb!";
            post3.TextColor = "green";

            Console.WriteLine(post1.BackgroundColor);
            Console.WriteLine(post1.Text);
            Console.WriteLine(post1.TextColor);
            Console.WriteLine(post2.BackgroundColor);
            Console.WriteLine(post2.Text);
            Console.WriteLine(post2.TextColor);
            Console.WriteLine(post3.BackgroundColor);
            Console.WriteLine(post3.Text);
            Console.WriteLine(post3.TextColor);
            //
            // -------------------------------------------------------------
            //
            // BlogPost Objects
            BlogPost blogPost1 = new BlogPost();
            blogPost1.AuthorName = "John Doe";
            blogPost1.Title = "Lorem Ipsum";
            blogPost1.Text = "Lorem ipsum dolor sit amet.";
            blogPost1.PublicationDate = "2000.05.04";

            BlogPost blogPost2 = new BlogPost();
            blogPost2.AuthorName = "Tim Urban";
            blogPost2.Title = "Wait but why";
            blogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogPost2.PublicationDate = "2010.10.10";

            BlogPost blogPost3 = new BlogPost();
            blogPost3.AuthorName = "William Turton";
            blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.\r\n";
            blogPost3.PublicationDate = "2017.03.28";

            Console.WriteLine(blogPost1.AuthorName);
            Console.WriteLine(blogPost1.Title);
            Console.WriteLine(blogPost2.Text);
            Console.WriteLine(blogPost3.PublicationDate);
            //
            // -------------------------------------------------------------
            //
            // Animal Objects
            Animal cat = new Animal();
            Animal dog = new Animal();
            Console.WriteLine("Before play");
            Console.WriteLine($"Cat hunger: {cat.hunger}, Cat thirst: {cat.thirst}");
            Console.WriteLine($"Dog hunger: {dog.hunger}, Dog thirst: {dog.thirst}");

            cat.Play();
            cat.Eat();
            cat.Drink();
            dog.Play();
            cat.Play();
            dog.Play();
            dog.Play();

            Console.WriteLine("After play");
            Console.WriteLine($"Cat hunger: {cat.hunger}, Cat thirst: {cat.thirst}");
            Console.WriteLine($"Dog hunger: {dog.hunger}, Dog thirst: {dog.thirst}");
            //
        }
    }
}
*/