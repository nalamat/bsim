/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2012-2014, Nima Alamatsaz, All rights reserved          *
 * Email: nnalamat@gmail.com                                             *
 * Web:   http://github.com/nalamat/bsim                                 *
 *                                                                       *
 * BSIM is free software: you can redistribute it and/or modify it       *
 * under the terms of the GNU General Public License version 3 as        *
 * published by the Free Software Foundation.                            *
 *                                                                       *
 * BSIM is distributed in the hope that it will be useful,               *
 * but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the          *
 * GNU General Public License for more details.                          *
 *                                                                       *
 * You should have received a copy of the GNU General Public License     *
 * along with BSIM. If not, see <http://www.gnu.org/licenses/>.          *
 *                                                                       *
 *************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace bsim
{
	public enum ButtonMouseState
	{
		Normal,
		Over,
		Down
	}

	public enum ButtonStyle
	{
		None,
		Standard,
		Menu,
	}

	public enum ControlRegion
	{
		Rectangle,
		CorneredRectangle,
		RoundedRectangle,
		Ellipse,
	}

	public enum ButtonArrow
	{
		None,
		Left,
		Top,
		Right,
		Bottom,
	}

	[Designer(typeof(RegisterBoxDesigner))]
	public class RegisterBox : Button
	{
		#region Declarations
		private Bitmap _back;
		private Image _imageDisabled;
		private Image _imageDown;
		private Image _imageNormal;
		private Image _imageOver;
		private Image _icon;
		private ButtonMouseState _buttonMouseState;
		private ControlRegion _controlRegion;
		private ButtonStyle _buttonStyle;
		private Size _iconSize;
		private ButtonArrow _buttonArrow;
		#endregion

		#region Constructor
		public RegisterBox()
		{
			_imageDisabled = null;
			_imageDown = null;
			_imageNormal = null;
			_imageOver = null;
			_icon = null;
			_buttonMouseState = ButtonMouseState.Normal;
			_buttonStyle = ButtonStyle.Standard;
			_controlRegion = ControlRegion.RoundedRectangle;
			_iconSize = new Size(32, 32);
			_buttonArrow = ButtonArrow.None;

			BackColor = Color.Transparent;
			UseVisualStyleBackColor = false;

			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.SetStyle(ControlStyles.Selectable, false);
			this.Refresh();
		}
		#endregion

		#region Destructor
		~HomaButton()
		{

		}
		#endregion

		#region Overrode Functions
		#region OnPaint
		protected override void OnPaint(PaintEventArgs e)
		{
			//e.Graphics.Clear(BackColor);
			e.Graphics.DrawImage(_back, 0, 0);
		}
		#endregion

		#region OnResize
		protected override void OnResize(EventArgs e)
		{
			this.Refresh();
			base.OnResize(e);
		}
		#endregion

		#region OnMouseEnter
		protected override void OnMouseEnter(EventArgs e)
		{
			_buttonMouseState = ButtonMouseState.Over;
			this.Refresh();

			base.OnMouseEnter(e);
		}
		#endregion

		#region OnMouseLeave
		protected override void OnMouseLeave(EventArgs e)
		{
			_buttonMouseState = ButtonMouseState.Normal;
			this.Refresh();

			base.OnMouseLeave(e);
		}
		#endregion

		#region OnMouseDown
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_buttonMouseState = ButtonMouseState.Down;
				this.Refresh();
			}

			base.OnMouseDown(e);
		}
		#endregion

		#region OnMouseMove
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ButtonMouseState s = _buttonMouseState;

				if (Parent.GetChildAtPoint(new Point(Left + e.X, Top + e.Y)) == this)
				{
					_buttonMouseState = ButtonMouseState.Down;
				}
				else
				{
					_buttonMouseState = ButtonMouseState.Normal;
				}

				if (s != _buttonMouseState) this.Refresh();
			}

			base.OnMouseMove(e);
		}
		#endregion

		#region OnMouseUp
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (Parent.GetChildAtPoint(new Point(Left + e.X, Top + e.Y)) == this)
				{
					_buttonMouseState = ButtonMouseState.Over;
				}
				else
				{
					_buttonMouseState = ButtonMouseState.Normal;
				}

				this.Refresh();
			}

			base.OnMouseUp(e);
		}
		#endregion

		#region Refresh
		public override void Refresh()
		{
			try
			{
				if (Parent == null) return;

				if (_buttonStyle == ButtonStyle.Standard)
				{
					_controlRegion = ControlRegion.RoundedRectangle;
				}
				else if (_buttonStyle == ButtonStyle.Menu)
				{
					_controlRegion = ControlRegion.Rectangle;
				}

				this.InitializeGraphics();
				PaintEventArgs e = new PaintEventArgs(this.CreateGraphics(), ClientRectangle);
				this.OnPaint(e);
			}
			catch (ObjectDisposedException)
			{
			}
			catch (Win32Exception)
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("HomaControls.Buttons.HomaButton.Refresh():\n\n" + ex.Message, Application.ProductName);
			}
		}
		#endregion

		#region OnBackColorChanged
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.Refresh();
		}
		#endregion

		#region OnTextChanged
		protected override void OnTextChanged(EventArgs e)
		{
			this.Refresh();
			base.OnTextChanged(e);
		}
		#endregion

		#region OnLocationChanged
		protected override void OnLocationChanged(EventArgs e)
		{
			this.Refresh();
			base.OnLocationChanged(e);
		}
		#endregion

		#region OnEnabledChanged
		protected override void OnEnabledChanged(EventArgs e)
		{
			this.Refresh();
			base.OnEnabledChanged(e);
		}
		#endregion

		#region OnParentChanged
		protected override void OnParentChanged(EventArgs e)
		{
			this.Refresh();
			base.OnParentChanged(e);
		}
		#endregion

		#region OnParentBackColorChanged
		protected override void OnParentBackColorChanged(EventArgs e)
		{
			base.OnParentBackColorChanged(e);
			this.Refresh();
		}
		#endregion

		#region CreateParams
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				//cp.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
				return cp;
			}
		}
		#endregion
		#endregion

		#region Graphics Functions
		#region InitializeGraphics
		private void InitializeGraphics()
		{
			try
			{
				if (_back != null)
				{
					_back.Dispose();
					_back = null;
				}

				if (Width == 0 || Height == 0) _back = new Bitmap(1, 1);
				else
				{
					_back = new Bitmap(Width, Height);
					Graphics g = Graphics.FromImage(_back);
					g.Clear(BackColor);

					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

					this.DrawParent(g);
					this.DrawBackground(g);
					this.DrawImage(g);
					this.DrawText(g);
					this.DrawIcon(g);
					this.DrawArrow(g);
					this.DrawRegion(g);

					g.Dispose();
					g = null;
				}

				GC.Collect();
			}
			catch (ObjectDisposedException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (Win32Exception)
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("HomaControls.Buttons.HomaButton.InitializeGraphics():\n\n" + ex.ToString(), Application.ProductName);
			}
		}
		#endregion

		#region DrawParent
		private void DrawParent(Graphics g)
		{
			try
			{
				if (Parent == null || BackColor.A == 255) return;

				//if (Parent is IGraphics && (Parent as IGraphics).Back != null)
				//{
				//	g.DrawImage((Parent as IGraphics).Back, -Left, -Top);
				//	g.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
				//}
				//else
				//{
					//e.DrawImage(Parent.DrawToBitmap(), -Left, -Top);
					g.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
					g.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
				//}
			}
			catch
			{
			}
		}
		#endregion

		#region DrawBackground
		private void DrawBackground(Graphics g)
		{
			try
			{
				if (_buttonStyle == ButtonStyle.None) return;

				if (_buttonStyle == ButtonStyle.Standard)
				{
					if (Enabled == false) g.DrawImage(HomaImages.Buttons.StandardDisabled, ClientRectangle);
					else switch (_buttonMouseState)
						{
							case ButtonMouseState.Down:
								g.DrawImage(HomaImages.Buttons.StandardDown, ClientRectangle);
								break;
							case ButtonMouseState.Normal:
								g.DrawImage(HomaImages.Buttons.StandardNormal, ClientRectangle);
								break;
							case ButtonMouseState.Over:
								g.DrawImage(HomaImages.Buttons.StandardOver, ClientRectangle);
								break;
						}
				}
				else if (_buttonStyle == ButtonStyle.Menu)
				{
					if (Enabled == false) g.DrawImage(HomaImages.Buttons.MenuDisabled, ClientRectangle);
					else switch (_buttonMouseState)
						{
							case ButtonMouseState.Down:
								g.DrawImage(HomaImages.Buttons.MenuDown, ClientRectangle);
								break;
							case ButtonMouseState.Normal:
								g.DrawImage(HomaImages.Buttons.MenuNormal, ClientRectangle);
								break;
							case ButtonMouseState.Over:
								g.DrawImage(HomaImages.Buttons.MenuOver, ClientRectangle);
								break;
						}
				}
			}
			catch
			{
			}
		}
		#endregion

		#region DrawImage
		private void DrawImage(Graphics g)
		{
			try
			{
				if (Enabled == false)
				{
					if (_imageDown != null) g.DrawImage(_imageDisabled, ClientRectangle);
				}
				else switch (_buttonMouseState)
					{
						case ButtonMouseState.Down:
							if (_imageDown != null) g.DrawImage(_imageDown, ClientRectangle);
							break;
						case ButtonMouseState.Normal:
							if (_imageNormal != null) g.DrawImage(_imageNormal, ClientRectangle);
							break;
						case ButtonMouseState.Over:
							if (_imageOver != null) g.DrawImage(_imageOver, ClientRectangle);
							break;
					}
			}
			catch
			{
			}
		}
		#endregion

		#region DrawText
		private void DrawText(Graphics g)
		{
			try
			{
				Color color = Color.Black;

				if (_buttonStyle == ButtonStyle.Standard || _buttonStyle == ButtonStyle.None)
				{
					if (!Enabled) color = HomaIO.GUI.ButtonForeColorStandardDisabled;
					else switch (_buttonMouseState)
						{
							case ButtonMouseState.Down:
								color = HomaIO.GUI.ButtonForeColorStandardDown;
								break;
							case ButtonMouseState.Normal:
								color = HomaIO.GUI.ButtonForeColorStandardNormal;
								break;
							case ButtonMouseState.Over:
								color = HomaIO.GUI.ButtonForeColorStandardOver;
								break;
						}
				}
				else if (_buttonStyle == ButtonStyle.Menu)
				{
					if (!Enabled) color = HomaIO.GUI.ButtonForeColorMenuDisabled;
					else switch (_buttonMouseState)
						{
							case ButtonMouseState.Down:
								color = HomaIO.GUI.ButtonForeColorMenuDown;
								break;
							case ButtonMouseState.Normal:
								color = HomaIO.GUI.ButtonForeColorMenuNormal;
								break;
							case ButtonMouseState.Over:
								color = HomaIO.GUI.ButtonForeColorMenuOver;
								break;
						}
				}

				Brush brushFore = new SolidBrush(color);
				Font font;

				if (_buttonStyle == ButtonStyle.Menu) font = HomaIO.GUI.ButtonFontMenu;
				else font = HomaIO.GUI.ButtonFontStandard;

				// Draw text
				SizeF textSize = this.StringSizeF(Text, font);
				float margin = (_icon != null ? _iconSize.Width : 0);
				textSize.Width += margin;

				float x = (Width - textSize.Width) / 2 + margin;
				float y = (Height - textSize.Height) / 2;

				g.DrawString(Text, font, brushFore, x, y);

				brushFore.Dispose();
				font = null;
				brushFore = null;
			}
			catch
			{
			}
		}
		#endregion

		#region DrawIcon
		private void DrawIcon(Graphics g)
		{
			try
			{
				if (_icon == null) return;

				Image icon = new Bitmap(_icon); //, _iconSize);

				Font font;

				if (_buttonStyle == ButtonStyle.Menu) font = HomaIO.GUI.ButtonFontMenu;
				else font = HomaIO.GUI.ButtonFontStandard;

				SizeF textSize = this.StringSizeF(Text, font);
				float margin = _iconSize.Width;
				textSize.Width += margin;

				float x = (Width - textSize.Width) / 2;
				float y = (Height - _iconSize.Height) / 2;

				if (!Enabled)
				{
					Bitmap bitmap = new Bitmap(icon);
					Color color;

					for (int i = 0; i < bitmap.Width; i++)
						for (int j = 0; j < bitmap.Height; j++)
							if ((color = bitmap.GetPixel(i, j)).A != 0)
								bitmap.SetPixel(i, j, Color.FromArgb(color.A / 2, color.R, color.G, color.B));

					icon.Dispose();
					icon = (Image)bitmap.Clone();

					bitmap.Dispose();
					bitmap = null;
				}

				g.DrawImage(icon, x, y);

				icon.Dispose();
				icon = null;
				font = null;
			}
			catch
			{
			}
		}
		#endregion

		#region DrawArrow
		private void DrawArrow(Graphics g)
		{
			try
			{
				if (_buttonArrow == ButtonArrow.None) return;

				Rectangle rect = ClientRectangle;
				GraphicsPath arrowBorderPath = new GraphicsPath();

				if (_buttonArrow == ButtonArrow.Bottom) arrowBorderPath.AddLines(new Point[]
				{
					new Point(rect.Left + 0 , rect.Top + 5   ),
					new Point(rect.Left + 1 , rect.Top + 5   ),
					new Point(rect.Left + 1 , rect.Top + 3   ),
					new Point(rect.Left + 2 , rect.Top + 3   ),
					new Point(rect.Left + 2 , rect.Top + 2   ),
					new Point(rect.Left + 3 , rect.Top + 2   ),
					new Point(rect.Left + 3 , rect.Top + 1   ),
					new Point(rect.Left + 5 , rect.Top + 1   ),
					new Point(rect.Left + 5 , rect.Top + 0   ),

					new Point(rect.Right - 5, rect.Top + 0   ),
					new Point(rect.Right - 5, rect.Top + 1   ),
					new Point(rect.Right - 3, rect.Top + 1   ),
					new Point(rect.Right - 3, rect.Top + 2   ),
					new Point(rect.Right - 2, rect.Top + 2   ),
					new Point(rect.Right - 2, rect.Top + 3   ),
					new Point(rect.Right - 1, rect.Top + 3   ),
					new Point(rect.Right - 1, rect.Top + 5   ),
					new Point(rect.Right - 0, rect.Top + 5   ),
					
					new Point(rect.Right - 0, rect.Bottom - 5),
					new Point(rect.Right - 1, rect.Bottom - 5),
					new Point(rect.Right - 1, rect.Bottom - 3),
					new Point(rect.Right - 2, rect.Bottom - 3),
					new Point(rect.Right - 2, rect.Bottom - 2),
					new Point(rect.Right - 3, rect.Bottom - 2),
					new Point(rect.Right - 3, rect.Bottom - 1),
					new Point(rect.Right - 5, rect.Bottom - 1),
					new Point(rect.Right - 5, rect.Bottom - 0),

					new Point(rect.Left + 5 , rect.Bottom - 0),
					new Point(rect.Left + 5 , rect.Bottom - 1),
					new Point(rect.Left + 3 , rect.Bottom - 1),
					new Point(rect.Left + 3 , rect.Bottom - 2),
					new Point(rect.Left + 2 , rect.Bottom - 2),
					new Point(rect.Left + 2 , rect.Bottom - 3),
					new Point(rect.Left + 1 , rect.Bottom - 3),
					new Point(rect.Left + 1 , rect.Bottom - 5),
					new Point(rect.Left + 0 , rect.Bottom - 5),
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("HomaControls.Buttons.HomaButton.DrawArrow(Graphics g):\n\n" + ex.ToString(), Application.ProductName);
			}
		}
		#endregion

		#region DrawRegion
		private void DrawRegion(Graphics g)
		{
			try
			{
				GraphicsPath path = this.GetBorderPath();

				//e.DrawPath(Pens.Black, path);
				Region = new Region(path);

				path.Dispose();
				path = null;
			}
			catch
			{
			}
		}
		#endregion
		#endregion

		#region Private Functions
		#region GetBorderPath
		private GraphicsPath GetBorderPath()
		{
			Rectangle rect = ClientRectangle;

			GraphicsPath path = new GraphicsPath();

			switch (_controlRegion)
			{
				case ControlRegion.Rectangle:
					path.AddRectangle(rect);
					break;
				case ControlRegion.CorneredRectangle:
					path.AddLines(new Point[]
					{
						new Point(rect.Left + 0 , rect.Top + 1   ),
						new Point(rect.Left + 1 , rect.Top + 1   ),
						new Point(rect.Left + 1 , rect.Top + 0   ),

						new Point(rect.Right - 1, rect.Top + 0   ),
						new Point(rect.Right - 1, rect.Top + 1   ),
						new Point(rect.Right - 0, rect.Top + 1   ),
						
						new Point(rect.Right - 0, rect.Bottom - 1),
						new Point(rect.Right - 1, rect.Bottom - 1),
						new Point(rect.Right - 1, rect.Bottom - 0),

						new Point(rect.Left + 1 , rect.Bottom - 0),
						new Point(rect.Left + 1 , rect.Bottom - 1),
						new Point(rect.Left + 0 , rect.Bottom - 1),
					});
					break;
				case ControlRegion.RoundedRectangle:
					path.AddLines(new Point[]
					{
						new Point(rect.Left + 0 , rect.Top + 5   ),
						new Point(rect.Left + 1 , rect.Top + 5   ),
						new Point(rect.Left + 1 , rect.Top + 3   ),
						new Point(rect.Left + 2 , rect.Top + 3   ),
						new Point(rect.Left + 2 , rect.Top + 2   ),
						new Point(rect.Left + 3 , rect.Top + 2   ),
						new Point(rect.Left + 3 , rect.Top + 1   ),
						new Point(rect.Left + 5 , rect.Top + 1   ),
						new Point(rect.Left + 5 , rect.Top + 0   ),

						new Point(rect.Right - 5, rect.Top + 0   ),
						new Point(rect.Right - 5, rect.Top + 1   ),
						new Point(rect.Right - 3, rect.Top + 1   ),
						new Point(rect.Right - 3, rect.Top + 2   ),
						new Point(rect.Right - 2, rect.Top + 2   ),
						new Point(rect.Right - 2, rect.Top + 3   ),
						new Point(rect.Right - 1, rect.Top + 3   ),
						new Point(rect.Right - 1, rect.Top + 5   ),
						new Point(rect.Right - 0, rect.Top + 5   ),
						
						new Point(rect.Right - 0, rect.Bottom - 5),
						new Point(rect.Right - 1, rect.Bottom - 5),
						new Point(rect.Right - 1, rect.Bottom - 3),
						new Point(rect.Right - 2, rect.Bottom - 3),
						new Point(rect.Right - 2, rect.Bottom - 2),
						new Point(rect.Right - 3, rect.Bottom - 2),
						new Point(rect.Right - 3, rect.Bottom - 1),
						new Point(rect.Right - 5, rect.Bottom - 1),
						new Point(rect.Right - 5, rect.Bottom - 0),

						new Point(rect.Left + 5 , rect.Bottom - 0),
						new Point(rect.Left + 5 , rect.Bottom - 1),
						new Point(rect.Left + 3 , rect.Bottom - 1),
						new Point(rect.Left + 3 , rect.Bottom - 2),
						new Point(rect.Left + 2 , rect.Bottom - 2),
						new Point(rect.Left + 2 , rect.Bottom - 3),
						new Point(rect.Left + 1 , rect.Bottom - 3),
						new Point(rect.Left + 1 , rect.Bottom - 5),
						new Point(rect.Left + 0 , rect.Bottom - 5),
					});
					break;
				case ControlRegion.Ellipse:
					path.AddEllipse(rect.X - 1, rect.Y - 1, rect.Width + 1, rect.Height + 1);
					break;
			}

			path.CloseAllFigures();

			return path;
		}
		#endregion

		#region StringSize
		private Size StringSize(string text, Font font)
		{
			Graphics g = this.CreateGraphics();
			Size size = g.MeasureString(text, font).ToSize();

			g.Dispose();
			g = null;

			return size;
		}
		#endregion

		#region StringSizeF
		private SizeF StringSizeF(string text, Font font)
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString(text, font);

			g.Dispose();
			g = null;

			return sizeF;
		}
		#endregion
		#endregion

		#region Properties
		#region ImageDisabled
		public Image ImageDisabled
		{
			get
			{
				return _imageDisabled;
			}
			set
			{
				_imageDisabled = value;
				this.Refresh();
			}
		}
		#endregion

		#region ImageDown
		public Image ImageDown
		{
			get
			{
				return _imageDown;
			}
			set
			{
				_imageDown = value;
				this.Refresh();
			}
		}
		#endregion

		#region ImageNormal
		public Image ImageNormal
		{
			get
			{
				return _imageNormal;
			}
			set
			{
				_imageNormal = value;
				this.Refresh();
			}
		}
		#endregion

		#region ImageOver
		public Image ImageOver
		{
			get
			{
				return _imageOver;
			}
			set
			{
				_imageOver = value;
				this.Refresh();
			}
		}
		#endregion

		#region Icon
		public Image Icon
		{
			get
			{
				return _icon;
			}
			set
			{
				_icon = value;
				if (Parent != null) Parent.Refresh();
			}
		}
		#endregion

		#region ControlRegion
		public ControlRegion ControlRegion
		{
			get
			{
				return _controlRegion;
			}
			set
			{
				_controlRegion = value;

				this.Refresh();
			}
		}
		#endregion

		#region ButtonStyle
		public ButtonStyle ButtonStyle
		{
			get
			{
				return _buttonStyle;
			}
			set
			{
				_buttonStyle = value;

				this.Refresh();
			}
		}
		#endregion
		#endregion

		#region Settings Events
		private void Settings_UserFieldChanged()
		{
			this.Refresh();
		}

		private void Settings_LanguageChanged()
		{
			this.Refresh();
		}
		#endregion

		#region Parent Events
		private void Parent_InitializedGraphics(object sender, EventArgs e)
		{
			this.Refresh();
		}
		#endregion
	}
}
