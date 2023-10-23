using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace avtoKurs
{
	public class User
	{
		private int idUser;
		private string login;
		private string pass;
		private string rights;

		public User(int idUser, string login, string pass, string rights)
		{
			this.idUser = idUser;
			this.login = login;
			this.pass = pass;
			this.rights = rights;
		}

		public int IdUser
		{
			get { return idUser; }
			set { idUser = value; }
		}

		public string Login
		{
			get { return login; }
			set { login = value; }
		}

		public string Pass
		{
			get { return pass; }
			set { pass = value; }
		}

		public string Rights
		{
			get { return rights; }
			set { rights = value; }
		}

		public void DeleteUser(int idUser)
		{
			throw new System.NotImplementedException();
		}

		public void AddUser()
		{
			throw new System.NotImplementedException();
		}
	}
}