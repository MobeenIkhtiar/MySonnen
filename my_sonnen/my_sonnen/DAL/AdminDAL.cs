using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using my_sonnen.Models;
namespace my_sonnen.DAL
{
    public class AdminDAL
    {
        #region ExtendedWarranty
        public List<ExtendedWarranty> getExtendedWarrantysList()
        {
            SonnenDBEntities db = new SonnenDBEntities();
            List<ExtendedWarranty> ExtendedWarrantys = db.ExtendedWarranties.ToList();

            return ExtendedWarrantys;
        }
        public List<ExtendedWarranty> getAllExtendedWarrantysList()
        {
            SonnenDBEntities db = new SonnenDBEntities();
            List<ExtendedWarranty> ExtendedWarrantys = db.ExtendedWarranties.ToList();

            return ExtendedWarrantys;
        }
        
        public ExtendedWarranty getExtendedWarrantyById(int _Id)
        {
            ExtendedWarranty ExtendedWarranty;
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                ExtendedWarranty = db.ExtendedWarranties.FirstOrDefault(x => x.Id == _Id);
            }

            return ExtendedWarranty;
        }

        public bool AddExtendedWarranty(ExtendedWarranty _ExtendedWarranty)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.ExtendedWarranties.Add(_ExtendedWarranty);
                db.SaveChanges();
            }
            return true;
        }

        public bool UpdateExtendedWarranty(ExtendedWarranty _ExtendedWarranty)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.Entry(_ExtendedWarranty).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public void DeleteExtendedWarranty(int _id)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.ExtendedWarranties.Remove(db.ExtendedWarranties.FirstOrDefault(x => x.Id == _id));
                db.SaveChanges();
            }
        }
        #endregion

        #region Installer
        public List<Installer> getInstallersList()
        {
            SonnenDBEntities db = new SonnenDBEntities();
            List<Installer> Installers = db.Installers.ToList();

            return Installers;
        }
        public List<Installer> getAllInstallersList()
        {
            SonnenDBEntities db = new SonnenDBEntities();
            List<Installer> Installers = db.Installers.ToList();

            return Installers;
        }

        public Installer getInstallerById(int _Id)
        {
            Installer Installer;
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                Installer = db.Installers.FirstOrDefault(x => x.Id == _Id);
            }

            return Installer;
        }

        public bool AddInstaller(Installer _Installer)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.Installers.Add(_Installer);
                db.SaveChanges();
            }
            return true;
        }

        public bool UpdateInstaller(Installer _Installer)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.Entry(_Installer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public void DeleteInstaller(int _id)
        {
            using (SonnenDBEntities db = new SonnenDBEntities())
            {
                db.ExtendedWarranties.Remove(db.ExtendedWarranties.FirstOrDefault(x => x.Id == _id));
                db.SaveChanges();
            }
        }
        #endregion
    }
}