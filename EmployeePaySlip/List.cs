namespace EmployeePaySlip
{
    public partial class List<T>
    {
        private T[] Array{get;set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}

        public T this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}

        }

        public  List()
        {
            _count=0;
            _capacity=8;
            Array=new T[_capacity];
        }
        public  List(int size)
        {
            _count=0;
            _capacity=8;
            Array=new T[_capacity];

        }
        public void Add(T value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count]=value;
            _count++;

        }
        public void GrowSize()
        {
            T[] temp=new T[_capacity*2];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];            
            }
            Array=temp;
            _capacity=_capacity*2;
        }
        
    }
}