﻿using System.Windows;
using System.Windows.Controls;

namespace Desktop.Metro.Controls
{
	public class TabHeader : ListBox
	{
		static TabHeader()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TabHeader), new FrameworkPropertyMetadata(typeof(TabHeader)));
		}
	}
}