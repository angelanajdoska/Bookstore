using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Data;

namespace Bookstore.Models
{
    public class SeedData
    {
         
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookstoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookstoreContext>>()))
            {
                
                if (context.Book.Any() || context.Movie.Any() || context.Author.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book { 
                        Picture="https://kupikniga.mk/wp-content/uploads/2018/03/203_1_43_12__8__2_2013shepnuvachot.jpg",
                        BooksID=1,
                        Authorid=context.Author.Single(d=>d.FirstName=="Донато" && d.LastName=="Каризи").AuthorID,
                        Title="Шепнувачот",
                        OriginalTitle="The whisperer",
                        Genre="Трилер",
                        Synopsis="Исчезнуваат пет девојчиња на возраст од осум до тринаесет години. Во меѓувреме пронајдено е местото на кое можеби се закопани, а го пронаоѓаат две момчиња со нивното куче сосем случајно. Но тоа не се нивните тела, сè што пронаоѓаат се неколку леви раце закопани во круг, поточно шест леви раце, а пет девојчиња се пријавени како исчезнати. Некаде уште едно девојче е киднапирано но сè уште не е пријавено како исчезнато.",
                        NumberofPages=597,
                        Price=400,
                        ReleaseDate=DateTime.Parse("2009-1-15"),
                        Publisher="Матица"
                    },
                     new Book { 
                        Picture="https://kupikniga.mk/wp-content/uploads/2018/03/328_31_15_11__10__3_201310.jpg",
                        BooksID=2,
                        Authorid=context.Author.Single(d=>d.FirstName=="Труман" && d.LastName=="Капоти").AuthorID,
                        Title="Појадок кај Тифани",
                        OriginalTitle="Breakfast at Tiffany’s",
                        Genre="Новела",
                        Synopsis="Њујорк и продавницата за скапоцен накит „Кај Тифани“ треба да спојат еден вечен сонувач и една лесна девојка која ги врти мажите на малиот прст. Во култниот истоимен филм Холи Голајтли ја игра Одри Хепберн, која просто брилјира во улогата на џебна Венера. Неповторлива книга која и ден денес влијае на повеќе форми на музика, мода, современа култура.",
                        NumberofPages=128,
                        Price=200,
                        ReleaseDate=DateTime.Parse("1958-10-16"),
                        Publisher="Антолог"
                    }
                      );
                context.SaveChanges();

                context.Movie.AddRange(
                    new Movie { 
                        Picture="https://upload.wikimedia.org/wikipedia/commons/4/4b/Breakfast_at_Tiffany%27s_%281961_poster%29.jpg",
                        MovieID=1000,
                        Title = "Breakfast at Tiffany's - Појадок кај Тифани",
                        BookId = context.Book.Single(d=>d.Title=="Појадок кај Тифани").BooksID,
                        ReleaseDate = DateTime.Parse("1961-10-5"),
                        Synopsis = "Одри Хепберн ја воодушевува публиката како безгрижната девојка Холи која низ Менхетен го бара милионерот од соништата за да се омажи. Џорџ Пепард го игра младиот писател кој е вовлечен во хаотичниот и волшебен животен стил на Холи.",
                        Trailer = "https://www.youtube.com/watch?v=hQ_O15kYlCI",
                        Rating = "7.7/10"
                    }                 
                );
                context.SaveChanges();

                context.Author.AddRange(
                    new Author { 
                        Picture="https://bio.illibraio.it/images/2843670207944_92_300_0_75.jpg",
                        AuthorID=100,
                        FirstName="Донато",
                        LastName="Каризи",
                        DateofBirth=DateTime.Parse("1973-3-15"),
                        DateofDeath=null,
                        Biography="47-годишниот автор е роден во 1973 година и студирал право и криминологија. Каризи од 1999 година работи како ТВ сценарист. Првиот роман на Каризи, „Шепнувачот“ му донел 5 меѓународни книжевни награди, бил продаден во над 20 држави и преведен на француски, дански, хебрејски и виетнамски. Творечкиот опус на Каризи константно се зголемува, а неговата последна книга L’uomo del labirinto (Човекот во лавиринтот) издадена во 2017 година повторно доживеа неверојатен успех со висока 4.5 оцена на скалата до 5. Морничавоста и напнатоста на дејствието, како и генијалните заплети, пресврти и добро исткаените ликови се она што го прават Каризи еден од најдобрите автори на жанрот трилер на денешницата.",
                        BooksId=context.Book.Single(d=>d.Title=="Шепнувачот").BooksID,
                        Rewards="David di Donatello за најдобар нов режисер"                       
                       },
                         new Author { 
                        Picture="https://upload.wikimedia.org/wikipedia/commons/7/73/Truman_Capote_NYWTS.jpg",
                        AuthorID=101,
                        FirstName="Труман",
                        LastName="Капоти",
                        DateofBirth=DateTime.Parse("1924-9-30"),
                        DateofDeath=DateTime.Parse("1984-8-25"),
                        Biography="Труман Капоти е американски романописец, сценарист, драматург и глумец, многу од чии раскази, романи, драми и документаристики се признаваат како литературни класики, вклучувајќи ја новелата Појадок кај Тифани и Во Ладна Крв - пресвртница во популарната култура.",
                        BooksId=context.Book.Single(d=>d.Title=="Појадок кај Тифани").BooksID,
                        Rewards="Награда Едгар и Еми награда"                       
                       }
                    );
                context.SaveChanges();

            }
        }
    }
}
