using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia13.DTO.Responses;
using Cwiczenia13.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia13.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ZamowieniaController : ControllerBase
    {
        private readonly CukierniaContext _context;

        public ZamowieniaController(CukierniaContext context)
        {
            _context = context;
        }

        [HttpGet("{lastname}")]
        public IActionResult getOrdersList(string lastname)
        {
            if (_context.Zamowienie.Count() == 0)
                return NoContent();

            var clients = _context.Klient.Where(k => k.Nazwisko.Equals(lastname)).ToArray();

            if (clients.Length == 0)
                return NotFound("Podany klient nie istnieje");

            var ordersList = new List<OrdersListResponse>();
            for (int i = 0; i < clients.Length; i++)
            {
                var client = clients[i];
                var zamowienia = _context.Zamowienie.Where(o => o.IdKlient == client.IdKlient).ToArray();

                if (zamowienia.Length == 0)
                    return NotFound("Brak zamowień dla podanego klienta");

                for (int j = 0; j < zamowienia.Length; j++)
                {
                    var zamowienie = zamowienia[j];

                    var order = new OrdersListResponse();
                    order.IdZamowienia = zamowienie.IdZamowienie;
                    order.DataPrzyjecia = zamowienie.DataPrzyjecia;
                    order.DataRealizacji = zamowienie.DataRealizacji;
                    order.Uwagi = zamowienie.Uwagi;
                    order.IdKlient = zamowienie.IdKlient;
                    order.IdPracownik = zamowienie.IdPracownik;
                    order.Zamowienie_Wyroby = new List<Zamowienie_WyrobResponse>();

                    var zamowienie_wyroby = _context.Zamowienie_WyrobCukierniczy.Where(zw => zw.IdZamowienia == zamowienie.IdZamowienie).ToArray();

                    for (int k = 0; k < zamowienie_wyroby.Count(); k++)
                    {
                        var zamowienie_wyrob = zamowienie_wyroby[k];

                        var tmp = new Zamowienie_WyrobResponse();
                        tmp.IdWyrob = zamowienie_wyrob.IdWyrobuCukierniczego;
                        tmp.Ilosc = zamowienie_wyrob.Ilosc;
                        tmp.Uwagi = zamowienie_wyrob.Uwagi;

                        order.Zamowienie_Wyroby.Add(tmp);
                    }

                    ordersList.Add(order);
                }
            }

            return Ok(ordersList);

        }

        [HttpGet]
        public IActionResult getOrdersList()
        {
            if (_context.Zamowienie.Count() == 0)
                return NoContent();

            var ordersList = new List<OrdersListResponse>();

            var zamowienia = _context.Zamowienie.ToArray();
            for (int i = 0; i < zamowienia.Length; i++)
            {
                var zamowienie = zamowienia[i];

                var order = new OrdersListResponse();
                order.IdZamowienia = zamowienie.IdZamowienie;
                order.DataPrzyjecia = zamowienie.DataPrzyjecia;
                order.DataRealizacji = zamowienie.DataRealizacji;
                order.Uwagi = zamowienie.Uwagi;
                order.IdKlient = zamowienie.IdKlient;
                order.IdPracownik = zamowienie.IdPracownik;
                order.Zamowienie_Wyroby = new List<Zamowienie_WyrobResponse>();

                var zamowienie_wyroby = _context.Zamowienie_WyrobCukierniczy.Where(zw => zw.IdZamowienia == zamowienie.IdZamowienie).ToArray();

                for (int j = 0; j < zamowienie_wyroby.Count(); j++)
                {
                    var zamowienie_wyrob = zamowienie_wyroby[j];

                    var tmp = new Zamowienie_WyrobResponse();
                    tmp.IdWyrob = zamowienie_wyrob.IdWyrobuCukierniczego;
                    tmp.Ilosc = zamowienie_wyrob.Ilosc;
                    tmp.Uwagi = zamowienie_wyrob.Uwagi;

                    order.Zamowienie_Wyroby.Add(tmp);
                }

                ordersList.Add(order);
            }

            return Ok(ordersList);
        }
    }
}