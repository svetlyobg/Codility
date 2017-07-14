using System;
//https://codility.com/programmers/lessons/2-arrays/
namespace x
{
	public class MyClass
	{
		public MyClass ()
		{
			if (A.Length == 0) return A;
			K = K % A.Length; 
			var result = new int[A.Length];
			Array.Copy(A, A.Length - K, result, 0, K);
			Array.Copy(A, 0, result, K, A.Length - K);
			return result;
		}
	}
}

