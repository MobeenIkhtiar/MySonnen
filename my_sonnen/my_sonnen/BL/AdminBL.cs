using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using my_sonnen.Models;
using my_sonnen.DAL;
namespace my_sonnen.BL
{
    public class AdminBL
    {
        #region ExtendedWarrantys
        public List<ExtendedWarranty> getExtendedWarrantysList()
        {
            return new AdminDAL().getExtendedWarrantysList();
        }
        public List<ExtendedWarranty> getAllExtendedWarrantysList()
        {
            return new AdminDAL().getAllExtendedWarrantysList();
        }
        public ExtendedWarranty getExtendedWarrantysById(int _id)
        {
            return new AdminDAL().getExtendedWarrantyById(_id);
        }

        public bool AddExtendedWarrantys(ExtendedWarranty _ExtendedWarrantys)
        {
            if (_ExtendedWarrantys.FirstName == null || _ExtendedWarrantys.LastName == null || _ExtendedWarrantys.State == null || _ExtendedWarrantys.ZipCode == null || _ExtendedWarrantys.Price == null || _ExtendedWarrantys.ExtendedWarranty1 == null || _ExtendedWarrantys.InstallDate == null || _ExtendedWarrantys.ProductInstalled == null || _ExtendedWarrantys.RegisterDate == null || _ExtendedWarrantys.SerialNumber == null || _ExtendedWarrantys.Phone == null || _ExtendedWarrantys.Email == null || _ExtendedWarrantys.Address1 == null || _ExtendedWarrantys.Capacity == null || _ExtendedWarrantys.City == null)
                return false;
            return new AdminDAL().AddExtendedWarranty(_ExtendedWarrantys);
        }

        public bool UpdateExtendedWarrantys(ExtendedWarranty _ExtendedWarrantys)
        {
            if (_ExtendedWarrantys.FirstName == null || _ExtendedWarrantys.LastName == null || _ExtendedWarrantys.State == null || _ExtendedWarrantys.ZipCode == null || _ExtendedWarrantys.Price == null || _ExtendedWarrantys.ExtendedWarranty1 == null || _ExtendedWarrantys.InstallDate == null || _ExtendedWarrantys.ProductInstalled == null || _ExtendedWarrantys.RegisterDate == null || _ExtendedWarrantys.SerialNumber == null || _ExtendedWarrantys.Phone == null || _ExtendedWarrantys.Email == null || _ExtendedWarrantys.Address1 == null || _ExtendedWarrantys.Capacity == null || _ExtendedWarrantys.City == null)
                return false;

            return new AdminDAL().UpdateExtendedWarranty(_ExtendedWarrantys);
        }

        public void DeleteExtendedWarrantys(int _id)
        {
            new AdminDAL().DeleteExtendedWarranty(_id);
        }
        #endregion

        #region Installers
        public List<Installer> getInstallersList()
        {
            return new AdminDAL().getInstallersList();
        }
        public List<Installer> getAllInstallersList()
        {
            return new AdminDAL().getAllInstallersList();
        }
        public Installer getInstallersById(int _id)
        {
            return new AdminDAL().getInstallerById(_id);
        }

        public bool AddInstallers(Installer _Installers)
        {
            if (_Installers.Name == null || _Installers.PartnerName == null || _Installers.Level == null )
                return false;
            return new AdminDAL().AddInstaller(_Installers);
        }

        public bool UpdateInstallers(Installer _Installers)
        {
            if (_Installers.Name == null || _Installers.PartnerName == null || _Installers.Level == null)
                return false;

            return new AdminDAL().UpdateInstaller(_Installers);
        }

        public void DeleteInstallers(int _id)
        {
            new AdminDAL().DeleteInstaller(_id);
        }
        #endregion
    }
}