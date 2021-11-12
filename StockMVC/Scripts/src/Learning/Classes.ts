{
    class Person {
        public FirstName: string;
        public LastName: string;
        public Email: string;
        private age: number;

        constructor(fn: string, ln: string, email: string, age: number) {
            this.FirstName = fn;
            this.LastName = ln;
            this.Email = email;
            this.age = age;
        }

        GreetMe() {
            console.log(`Hello ${this.FirstName}`);
        }
    }

    class Person2 {
        constructor(public FirstName: string,
            public LastName: string,
            public Email: string,
            private age: number) { }
        GreetMe() {
            console.log(`Hello ${this.FirstName}`);
        }
    }

    class Student extends Person {
        constructor(firstName: string,
            lastName: string,
            email: string,
            age: number,
            private grade: string) {
            super(firstName, lastName, email, age);
        }
        GreetMe() {
            super.GreetMe();
            console.log(`A ${this.grade} student`);
        }
    }

    interface IPhone {
        Model: string;
        Version: number;
        Ring(): string;
    }

    class SmartPhone implements IPhone {
        constructor(public Model: string,
            public Version: number) { }
        Ring(): string {
            return "DigDigDig";
        }
    }

    class OldPhone implements IPhone {
        constructor(public Model: string,
            public Version: number) { }
        Ring(): string {
            return "OldOldOld";
        }
    }











    let p1 = new Person("Ali", "Nejati", "ali62n62@yahoo.com", 37);
    let p2 = new Person2("Ali", "Nejati", "ali62n62@yahoo.com", 37);
    let s1 = new Student("Reza", "Nejati", "ali62n62@yahoo.com", 37, "PhD");
    

    p1.GreetMe();
    p2.GreetMe();
    s1.GreetMe();

}