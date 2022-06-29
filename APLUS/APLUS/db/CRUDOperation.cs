using APLUS.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace APLUS.db
{
    public class CRUDOperation
    {
        readonly SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<ProjectModel>();
            db.CreateTable<Client>();
        }
        public IEnumerable<ProjectModel> GetProjects()
        {
            return db.Table<ProjectModel>();
        }
        public IEnumerable<Client> GetClients()
        {
            return db.Table<Client>();
        }

        public ProjectModel GetProjectItem(int id)
        {
            return db.Get<ProjectModel>(id);
        }

        public int DelProj(int id) { return db.Delete<ProjectModel>(id); }

        public int SaveItem(ProjectModel projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

        public int SaveClient(Client projectModel)
        {
            return db.Insert(projectModel);

        }
    }
}
