using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using System.Collections.ObjectModel;
using System.IO;


namespace oop_labs;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        ObservableCollection<Transport> transportList = new ObservableCollection<Transport>
        {
            new Plane(),
            new Car(),
            new SportCar(),
            new CargoPlane(),
            new Truck(),
            new PassengerPlane()

        };
        
        Title = "Transport Gallery";
        Width = 600;
        Height = 400;
        var car = new Car();
        
        var itemsControl = new ItemsControl
        {
            ItemsSource = transportList,
            ItemsPanel = new FuncTemplate<Panel>(() => new WrapPanel()),
            ItemTemplate = new FuncDataTemplate<Transport>((item, _) =>
            {
                var bitmap = new Bitmap(item.pictureURL);
                return new StackPanel
                {
                    Children =
                    {
                        new Image
                        {
                            Source = bitmap,
                            Width = 200,
                            Height = 200
                        },
                        new TextBlock
                        {
                            Text = item.GetType().Name,
                            HorizontalAlignment = HorizontalAlignment.Center
                        },
                        new TextBlock
                        {
                            Text = item.ToString(),
                            HorizontalAlignment = HorizontalAlignment.Center,
                        }
                    }
                };
            })
        };
        car.year = 100;
        Console.WriteLine(car.ToString());
        Console.WriteLine(Transport.objectAmount);
        Car car2 = new Car();
        Car car3 = new Car();
        Car car4 = new Car();
        Console.WriteLine(Transport.objectAmount);
        var scrollViewer = new ScrollViewer
        {
            Content = itemsControl
        };

        Content = scrollViewer;
        

    }
}