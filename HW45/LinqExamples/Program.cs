using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Выполняется
            Func<string, string> greeting = str => $"Hello {str}";

            //Описывает то, что должно выполниться
            //Чтобы вызвать, нужно преобразовать
            Expression<Func<string, string>> expression = str => $"Hello {str}";


            Product[] products =
            {
                new Product("T-shirt", 200),
                new Product("Cap",1000),
                new Product("T-shirt",400),
                new Product("Cap",600),
                new Product("Pants",400),
                new Product("Shoes",1400),
                new Product("T-shirt",7400),
                new Product("T-shirt",60),
                new Product("Shoes",200000),
                new Product("Pants",4500),
            };

            Rule[] filter =
            {
                new Rule
                {
                    PropertyName = "Category",
                    Value = "T-shirt",
                    ExpressionType = ExpressionType.Equal,
                },

                new Rule
                {
                    PropertyName = "Category",
                    Value = "Cap",
                    ExpressionType = ExpressionType.Equal,
                    AppendType = AppendType.OrElse
                },

                new Rule
                {
                    PropertyName = "Price",
                    Value = 1000,
                    ExpressionType = ExpressionType.LessThanOrEqual,
                }

            };

            Func<Product, int> priceSelector = product => product.Price;

            IQueryable<Product> sequence = products.AsQueryable()
                                                   .Where(ExpressionExample.CreateProductFilter(filter))
                                                   .OrderByFieldOrProperty("Price");

            foreach (var item in sequence)
                Console.WriteLine($" { item.Category} : {item.Price}");

        } 
    }
}
