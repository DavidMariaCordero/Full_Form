using System;
using System.Linq;
using System.Linq.Expressions;
using Full_Form.DAL;
using Full_Form;
using System.Collections.Generic;
using Full_Form.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Full_Form.BLL
{
    public class EmployeesBLL
    {
        public static bool Save(Employees employee)
        {
            if (!Exist(employee.Id))
                return Insert(employee);
            else
                return Modify(employee);
        }
        private static bool Insert(Employees employee)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Employees.Add(employee);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modify(Employees employees)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(employees).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Delete(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var employees = contexto.Employees.Find(id);
                if (employees != null)
                {
                    contexto.Employees.Remove(employees);//remover la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Employees Search(int id)
        {
            Contexto contexto = new Contexto();
            Employees employees;
            try
            {
                employees = contexto.Employees.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return employees;
        }
        public static bool Exist(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Employees.Any(e => e.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
    }
}