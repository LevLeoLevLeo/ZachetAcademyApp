   M S B A M L   `   `   `  ����K  GZachetAcademyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZachetAcademyApp.PagesZachetAcademyApp.Pages  5      +    %ZachetAcademyApp.Pages.PageAddStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ZachetAcademyApp.Pages     5        N� Title$  PageAddStudent��5	       N� WindowTitle$' !Добавление оценок��5
      .��5      � .+�5   
   �� $��Center=�6   $	��Top=�61   $'��!Добавить студента��6I   $
��30pt(�6b   �� 5   
      	StpCenter#��[  6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��0 10 0 0q�6N   .+�5      �� $��ФИО студента:��6   $
��15pt(�61   �� 5      -   5        $��Txb_NameStudent��5      $��150px��61   $
��Left=�6?   $��10 0 0 0q�6Z   5      �� 5      $ 
Horizontal=�6   $��Right=�62   $��0 10 0 0q�6N   .+�5      �� $!��Специальность:��6   $
��15pt(�62   �� 5      -   5        $��Cmd_Specialization��5      $��10 0 0 0q�65   $��150px��6G   5      �� 5       $ 
Horizontal=�6   $��Right=�62   $��0 10 0 0q�6N   .+�5"      �� $$��Год поступления:��6   $
��15pt(�64   (  "System.Windows.Controls.DatePicker  5#      -   5        $��Dtp_Year��5#      $��10 0 0 0q�6-   $��150px��6?   5%      �� 5'      $ 
Horizontal=�6   $��Right=�62   $��0 10 0 0q�6N   .+�5)      �� $"��Форма обучения:��6   $
��15pt(�63   �� 5*      -   5        $��Cmd_TrainingForm��5*      $��10 0 0 0q�63   $��150px��6E   5,      �� 5.      $ 
Horizontal=�6   $��Right=�62   $��0 10 0 0q�6N   .+�50      �� $$��Название группы:��6   $
��15pt(�64   �� 51      -   5        $��Cmd_NameGroup��51      $��10 0 0 0q�60   $��150px��6B   53      �� 55      -   5        $��Btn_AddStudent��55   9     
BtnDefault#��[ 6   $��Добавить��6O   $��150px��6b   $
��35px��6p   $��Right=�56      $��Center=�61   $��0 10 0 0q�6L   6^   58      5:      5<      