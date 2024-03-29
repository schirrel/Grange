﻿#if UNITY_4_6 || UNITY_5

using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UI;


namespace NodeCanvas.Tasks.Conditions{

	[Category("UGUI")]
	public class ButtonClicked : ConditionTask {

		[RequiredField]
		public BBParameter<Button> button;

		protected override string OnInit(){
			(button.value as Button).onClick.AddListener(OnClick);
			return null;
		}

		protected override bool OnCheck(){
			return false;
		}

		void OnClick(){
			YieldReturn(true);
		}
	}
}

#endif