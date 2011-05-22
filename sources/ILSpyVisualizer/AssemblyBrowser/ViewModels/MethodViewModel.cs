﻿using System.Windows.Media;
using ICSharpCode.ILSpy.TreeNodes;
using Mono.Cecil;
using ICSharpCode.ILSpy;

namespace ILSpyVisualizer.AssemblyBrowser.ViewModels
{
	class MethodViewModel : MemberViewModel
	{
		private readonly MethodDefinition _methodDefinition;

		public MethodViewModel(MethodDefinition methodDefinition)
		{
			_methodDefinition = methodDefinition;
		}

		public override ImageSource Icon
		{
			get { return MethodTreeNode.GetIcon(_methodDefinition); }
		}

		public override string Text
		{
			get
			{
				return MethodTreeNode
					.GetText(_methodDefinition, MainWindow.Instance.CurrentLanguage) as string;
			}
		}
	}
}