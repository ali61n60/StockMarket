var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
{
    var Person_1 = /** @class */ (function () {
        function Person(fn, ln, email, age) {
            this.FirstName = fn;
            this.LastName = ln;
            this.Email = email;
            this.age = age;
        }
        Person.prototype.GreetMe = function () {
            console.log("Hello " + this.FirstName);
        };
        return Person;
    }());
    var Person2 = /** @class */ (function () {
        function Person2(FirstName, LastName, Email, age) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.age = age;
        }
        Person2.prototype.GreetMe = function () {
            console.log("Hello " + this.FirstName);
        };
        return Person2;
    }());
    var Student = /** @class */ (function (_super) {
        __extends(Student, _super);
        function Student(firstName, lastName, email, age, grade) {
            var _this = _super.call(this, firstName, lastName, email, age) || this;
            _this.grade = grade;
            return _this;
        }
        Student.prototype.GreetMe = function () {
            _super.prototype.GreetMe.call(this);
            console.log("A " + this.grade + " student");
        };
        return Student;
    }(Person_1));
    var SmartPhone = /** @class */ (function () {
        function SmartPhone(Model, Version) {
            this.Model = Model;
            this.Version = Version;
        }
        SmartPhone.prototype.Ring = function () {
            return "DigDigDig";
        };
        return SmartPhone;
    }());
    var OldPhone = /** @class */ (function () {
        function OldPhone(Model, Version) {
            this.Model = Model;
            this.Version = Version;
        }
        OldPhone.prototype.Ring = function () {
            return "OldOldOld";
        };
        return OldPhone;
    }());
    var p1 = new Person_1("Ali", "Nejati", "ali62n62@yahoo.com", 37);
    var p2 = new Person2("Ali", "Nejati", "ali62n62@yahoo.com", 37);
    var s1 = new Student("Reza", "Nejati", "ali62n62@yahoo.com", 37, "PhD");
    p1.GreetMe();
    p2.GreetMe();
    s1.GreetMe();
}
//# sourceMappingURL=Classes.js.map