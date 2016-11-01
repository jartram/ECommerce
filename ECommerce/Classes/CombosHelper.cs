using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECommerce.Models;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {

        private static  ECommerceContext db = new ECommerceContext();

        public static List<Department> GetDepartments()
        {

            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a Department...]"
            });
            departments = departments.OrderBy(d => d.Name).ToList();

            return departments;

        }



        public static List<City> GetCities()
        {

            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Select a City...]"
            });
            cities = cities.OrderBy(d => d.Name).ToList();

            return cities;

        }



        public static List<Company> GetCompanies()
        {

            var companies = db.Companies.ToList();
            companies.Add(new Company
            {
                CityId = 0,
                Name = "[Select a Company...]"
            });
            companies = companies.OrderBy(d => d.Name).ToList();

            return companies;

        }



        void IDisposable.Dispose()
        {
            db.Dispose();
        }
    }
}