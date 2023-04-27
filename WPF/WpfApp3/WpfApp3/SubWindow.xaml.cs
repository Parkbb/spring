using System;
using System.Windows;

namespace WpfApp3
{
    /// <summary>
    /// SubWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubWindow : Window
    {
        //메인 윈도우의 하단 ListBox를 Refresh 하기 위한 델리게이트
        //메인 윈도우에서 직무추가 버튼을 클릭할 때 이벤트를 할당해 준다.
        public Delegate UpdateActor;

        public SubWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
