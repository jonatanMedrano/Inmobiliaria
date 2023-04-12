using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Administradora
    {
        private List<Dpto> dptos;
        private List<Casa> casas;
        private List<Cliente> clientes;
        private List<Vendedor> vendedores;

        //Contructor de la clase
        public Administradora()
        {
            dptos = new List<Dpto>();
            casas = new List<Casa>();
            clientes = new List<Cliente>();
            vendedores = new List<Vendedor>();
        }


        //-------DPTOS----------------------
        public void agregarDpto(Dpto d)
        {
            dptos.Add(d);
        }

        public void eliminarDpto(Dpto d)
        {
            dptos.Remove(d);
        }

        public List<Dpto> Dptos
        {
            get { return dptos; }
        }

        //-------CASAS----------------------
        public void agregarCasa(Casa c)
        {
            casas.Add(c);
        }

        public void eliminarCasa(Casa c)
        {
            casas.Remove(c);
        }

        public List<Casa> Casas
        {
            get { return casas; }
        }

        //-------CLIENTES----------------------
        public void agregarCliente(Cliente c)
        {
            clientes.Add(c);
        }

        public void eliminarCliente(Cliente c)
        {
            clientes.Remove(c);
        }

        public List<Cliente> Clientes
        {
            get { return clientes; }
        }

        //-------VENDEDORES----------------------
        public void agregarVendedor(Vendedor v)
        {
            vendedores.Add(v);
        }

        public void eliminarVendedor(Vendedor v)
        {
            vendedores.Remove(v);
        }

        public List<Vendedor> Vendedores
        {
            get { return vendedores; }
        }


    }
}