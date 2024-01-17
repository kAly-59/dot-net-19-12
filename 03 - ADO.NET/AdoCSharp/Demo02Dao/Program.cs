// See https://aka.ms/new-console-template for more information
using Demo02Dao.Classes;
using Demo02Dao.Dao;

var maitreDAO = new MaitreDAO();

var maitre = maitreDAO.GetOneById(1);

Console.WriteLine(maitre.ToString());

var chienDao = new ChienDAO();

var chiens = chienDao.GetAll();

chiens.ForEach(c => Console.WriteLine(c.ToString()));

var medor = chienDao.GetOneById(1);

Console.WriteLine(medor.ToString());

//var milou = new Chien("Milou", DateTime.Now);

//chienDao.Save(milou);

var milou = chienDao.GetOneById(2);
milou.Maitre = maitreDAO.GetOneById(1);

chienDao.Update(milou);