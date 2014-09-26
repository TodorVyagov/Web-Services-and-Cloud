namespace MusicCompany.Data
{
        using System;
    using System.Collections.Generic;

    using MusicCompany.Data.Repositories;
    using MusicCompany.Models;

    public class MusicCompanyData : IMusicCompanyData
    {
        private IMusicCompanyDbContext context;
        private IDictionary<Type, object> repositories;

        public MusicCompanyData()
            : this(new MusicCompanyDbContext())
        {
        }

        public MusicCompanyData(IMusicCompanyDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }

        public IRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(Repository<T>);

                //if (typeOfModel.IsAssignableFrom(typeof(Student)))
                //{
                //    type = typeof(StudentsRepository);
                //}

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}
