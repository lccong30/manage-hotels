using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHACHHANG
    {
        Entities db;

        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }

        public tb_KhachHang getOne(int idkh)
        {
            return db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idkh);
        }

        public List<tb_KhachHang> getAll()
        {
            return db.tb_KhachHang.ToList();
        }

        public void add(tb_KhachHang kh)
        {
            try
            {
                db.tb_KhachHang.Add(kh);
                db.SaveChanges();

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void update(tb_KhachHang kh, int id)
        {
            tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == id);
            _kh.HOTEN = kh.HOTEN;
            _kh.GIOITINH = kh.GIOITINH;
            _kh.CCCD = kh.CCCD;
            _kh.DIENTHOAI = kh.DIENTHOAI;
            _kh.DIACHI = kh.DIACHI;
            _kh.DISABLED = kh.DISABLED;
            _kh.EMAIL = kh.EMAIL;

            try
            {
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delete(int kh)
        {
            tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == kh);
            _kh.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
