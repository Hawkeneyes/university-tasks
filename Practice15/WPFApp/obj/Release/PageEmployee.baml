   M S B A M L   `   `   `  ���� 
  WPFApp    WPFApp.PageEmployee   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  PageEmployee��.���� $��3q�   BackgroundWindowResource#��[  .+�o� .@�m� $��Действие��.@�m� $��Отменить�� m� Command$
 Undo���� m� $��Создать��m� $ ��Редактировать��m� $��Сохранить ��$
 Undo��m� $��
Найти���� m� $��Удалить��m� $��
Отчет��c� -   $��ToolBar1��$��3q�.@��� -   $
��Undo�� � ToolTip$D >Отменить редактирование/создание��$��5,2,5,2q�$
��Undo��.���� $��/images/undo.png���� -   $	��Add��$8 2Добавить нового сотрудника��$��5,2,5,2q�.���� $��/images/add.png���� -   $
��Edit��$I CРедактировать данные по сотрудникам��$��5,2,5,2q�.���� $��/images/edit.png���� -   $
��Find��$9 3Найти данные по сотрудникам��$��5,2,5,2q�.���� $��/images/find.png���� -   $
��Save��$A ;Сохранить данные по сотрудникам��$��5,2,5,2q�$
��Undo��.���� $��/images/save.png���� -   $��Delete��$) #Удалить сотрудника��$��5,2,5,2q�.���� $��/images/delete.png���� $��5q�%#Список сотрудников&   System.Windows.Controls.DataGrid  -   $��DataGridEmployee��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��  $ Имя��  $ Отчество��4  .System.Windows.Controls.DataGridComboBoxColumn  $ Должность��4  .System.Windows.Controls.DataGridTemplateColumn  $ Дата рождения��  $ Телефон��  $' !Электронная почта��