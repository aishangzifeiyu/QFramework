﻿/****************************************************************************
 * Copyright (c) 2017 snowcold
 * Copyright (c) 2018 liangxie
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

namespace QFramework.Example
{
	using UnityEngine;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class ExtensionExample : MonoBehaviour 
	{
		// Use this for initialization
		private void Start ()
		{
			var simpleClass = new object ();

			if (simpleClass.IsNull ())
			{

			} else if (simpleClass.IsNotNull ())
			{

			}
				
			Action action = () => Debug.Log ("action called");
			action.InvokeGracefully ();

			Func<int> func = () => 1;
			func.InvokeGracefully ();

			var typeName = GenericExtention.GetTypeName<string> ();
			Debug.Log (typeName);

			var testArray = new int[] { 1, 2, 3 };
			testArray.ForEach (number => Debug.Log (number));

			IEnumerable<int> testIenumerable = new List<int> { 1, 2, 3 };
			testIenumerable.ForEach (number => Debug.Log (number));

			var testList = new List<int> { 1, 2, 3 };
			testList.ForEach (number => Debug.Log (number));
			testList.ForEachReverse (number => Debug.Log (number));

			var dictionary1 = new Dictionary<string,string> (){ { "1","2" } };
			var dictionary2 = new Dictionary<string,string> (){ { "3","4" } };
			var dictionary3 = dictionary1.Merge (dictionary2);
			dictionary1.ForEach (pair => Debug.LogFormat ("{0}:{1}", pair.Key, pair.Value));
		}
	}
}