using Microsoft.EntityFrameworkCore;

using movieAPP.Models;
using System.ComponentModel.DataAnnotations;

namespace movieAPP.Services
{
    public class BindMovies : IMovie
    {

        private readonly  MovieDBContext  _context;

        public BindMovies( MovieDBContext context)
        {
            _context = context; 
        }

        public string NewMovies(MovieViewModel model)
        {
          

           var entry = new  Movie
           {
                Title=model.Title,
                Director=model.Director,
                YearReleased=model.YearReleased



                // GrossIncome,
                // NetIncome=netSalary,
                // Salary=model.Salary,
                // FirstName=model.FirstName,
                // LastName=model.LastName,
                // Email=model.Email,
                // PhoneNumber = model.PhoneNumber,
                // State=model.State,
                // Country=model.Country,
                // Gender=model.Gender,
                // MiddleName=model.MiddleName,
                // City=model.City


           };

            _context.Add(entry);
           string success= _context.SaveChanges().ToString(); 
           return success;
            

        }

        // private decimal Tax(decimal SalaryAmount , int Percentage)
        // {
        //     decimal tax= (Percentage/100) *SalaryAmount;
        //     return tax;       
        // }

    }
}