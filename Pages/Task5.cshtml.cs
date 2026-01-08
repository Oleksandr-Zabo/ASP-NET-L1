using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class Quote { 
        public string Author { get; set; }
        public string ImgUrl { get; set; }
        public string Text { get; set; }

        public Quote(string author, string imgUrl, string text)
        {
            Author = author;
            ImgUrl = imgUrl;
            Text = text;
        }
    }
    public class Task5Model : PageModel
    {
        public readonly List<Quote> Quotes;
        public Quote ShowQuote { get; set; }
        Random rnd = new Random();
        public int rand;
        public Task5Model()
        {
            Quotes = new List<Quote>();
            Quotes.Add(new Quote("Mark Twain", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/authors/1322103868i/1244._UX200_CR0,40,200,200_.jpg", "“′Classic′ - a book which people praise and don't read.”"));
            
            Quotes.Add(new Quote("William Shakespeare", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/authors/1654446514i/947._UY200_CR0,0,200,200_.jpg", "“The first thing we do, let's kill all the lawyers.”"));
            
            Quotes.Add(new Quote("Publius Ovidius Naso", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/authors/1651504074i/1127._UX200_CR0,14,200,200_.jpg", "“Omnia mutantur, nihil interit (everything changes, nothing perishes).”"));
            
            Quotes.Add(new Quote("Charles Bukowski", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/authors/1501509674i/13275._UY200_CR33,0,200,200_.jpg", "“I often stood in front of the mirror alone, wondering how ugly a person could get.”"));
            
            Quotes.Add(new Quote("Bram Stoker", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/authors/1202438456i/6988.jpg", "“The blood is the life!”"));

        }
        public void OnGet()
        {
            rand = rnd.Next(0, Quotes.Count);
            ShowQuote = Quotes[rand];
        }
    }
}
