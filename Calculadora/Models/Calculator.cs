using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculator
    {
        private List<string> _history;
        private string data;
        public Calculator(string data){
            _history = new List<string>();
            this.data = data;
        }
        public int Add(int num1, int num2){
            int result = num1 + num2;
            _history.Insert(0, $"{num1} + {num2} = {result} | {data}");
            return result;
        }
        public int Subtract(int num1, int num2){
            int result = num1 - num2;
            _history.Insert(0, $"{num1} - {num2} = {result} | {data}");
            return result;
        }
        public int Multiply(int num1, int num2){
            int result = num1 * num2;
            _history.Insert(0, $"{num1} * {num2} = {result} | {data}");
            return result;
        }
        public int Divide(int num1, int num2){
            int result = num1 / num2;
            _history.Insert(0, $"{num1} / {num2} = {result} | {data}");
            return result;
        }
        public List<string> History(){
            _history.RemoveRange(3, _history.Count - 3);
            return _history;
        }
    }
}