//using Property to get and set the members
namespace OOP{
	public class Employee{
		private int _eid;
		private string name;
		private double sal;
		public int eid{
			get{return _eid;}
			set{_eid = value;}
		}
	
		public Employee(int eid,string name,double sal){
			_eid=eid;
			this.name=name;
			this.sal=sal;
		}
	}
}