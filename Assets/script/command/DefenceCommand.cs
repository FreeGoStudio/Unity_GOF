using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.script.command
{
	class DefenceCommand : ICommand
	{
		private GameActor _actor;

		public DefenceCommand(GameActor actor)
		{
			_actor = actor;
		}

		public void Execute()
		{
			Debug.Log(_actor.Name + " 防御一下");
		}

		public void Undo()
		{
			Debug.Log(_actor.Name + " 撤销防御");
		}
	}
}
