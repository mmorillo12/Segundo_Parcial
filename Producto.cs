using System;

namespace Segundo_Parcial
{
     class Producto{
        public string nombre;
        public int precio;
        public int existencia;
        public Producto(string nombre, int precio, int existencia){
            this.nombre = nombre;
            this.precio = precio;
            this.existencia = existencia;
        }
        public Producto(){}
     }
    
    class Pago{
        int cantidad;
        public void insertar_Pago(){
        Console.WriteLine("Inserte su pago: ");
        cantidad = int.Parse(Console.ReadLine());
        }
        public int Monto_insertado(){
            return cantidad;
        }
        public int Devuelta(int monto){
            if(monto > cantidad){
                return monto - cantidad;
            }
            return cantidad - monto;
        }
        public bool validarMoneda(){
            if(cantidad != 5 && cantidad != 10 && cantidad != 25 && cantidad != 50 && cantidad != 100 && cantidad != 200){
                Console.WriteLine("No se aceptan monedas de este tipo en esta maquina\n");
                return false;
            }
            return true;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pago pag = new Pago();
            Producto[] productos = new Producto[10];
            productos[0] = new Producto("Platanito",30, 10);
            productos[1] = new Producto("Coca-Cola",25, 5);
            productos[2] = new Producto("Chocolate",100, 5);
            productos[3] = new Producto("Agua",10, 30);
            productos[4] = new Producto("Cerveza",200, 40);
            productos[5] = new Producto("Sprite",60, 10);
            productos[6] = new Producto("Manies",30, 12);
            productos[7] = new Producto("Doritos",10, 10);
            productos[8] = new Producto("Gomitas",40, 15);
            productos[9] = new Producto("Jugo de Guayaba",25, 15);

            Producto[] productos_orginal = new Producto[10];
            for(int i = 0; i < productos.Length; i++){
                productos_orginal[i] = productos[i];
            }



            int va = 0;
            int precio_producto = productos[0].precio;
            string nombre_producto = productos[0].nombre;
            int existencia_producto = productos[0].existencia;
            do{
                Console.WriteLine("--MAQUINA DE DELICIAS ITLA--");
                Console.WriteLine("Monedas Permitidas: 5, 10, 25 y Billetes: 50, 100, 200");
                for(int i = 0; i < productos.Length; i++){
                    Console.WriteLine("{0} -- {1} ---> {2} pesos --> existencia: {3} --", i+1, productos[i].nombre, productos[i].precio, productos[i].existencia);
                }
                Console.WriteLine("11 -- Terminar o Mostrar Informe");
                Console.WriteLine();
                Console.WriteLine("Escoja un producto");
                va = int.Parse(Console.ReadLine());
                switch(va){                
                
                case 1:
                precio_producto = productos[0].precio;
                nombre_producto = productos[0].nombre;
                existencia_producto = productos[0].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[0].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 2:
                precio_producto = productos[1].precio;
                nombre_producto = productos[1].nombre;
                existencia_producto = productos[1].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[1].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 3:
                precio_producto = productos[2].precio;
                nombre_producto = productos[2].nombre;
                existencia_producto = productos[2].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[2].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 4:
                precio_producto = productos[3].precio;
                nombre_producto = productos[3].nombre;
                existencia_producto = productos[3].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[3].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 5:
                precio_producto = productos[4].precio;
                nombre_producto = productos[4].nombre;
                existencia_producto = productos[4].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[4].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 6:
                precio_producto = productos[5].precio;
                nombre_producto = productos[5].nombre;
                existencia_producto = productos[5].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[5].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 7:
                precio_producto = productos[6].precio;
                nombre_producto = productos[6].nombre;
                existencia_producto = productos[6].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[6].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 8:
                precio_producto = productos[7].precio;
                nombre_producto = productos[7].nombre;
                existencia_producto = productos[7].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[7].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 9:
                precio_producto = productos[8].precio;
                nombre_producto = productos[8].nombre;
                existencia_producto = productos[8].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[8].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 10:
                precio_producto = productos[9].precio;
                nombre_producto = productos[9].nombre;
                existencia_producto = productos[9].existencia;
                if(existencia_producto > 0){
                Console.WriteLine("Seleccionaste un {0} con una valor de {1} pesos", nombre_producto, precio_producto);
                pag.insertar_Pago();
                if(pag.validarMoneda() == false){
                    break;
                }
                Console.WriteLine("Usted inserto {0} pesos",pag.Monto_insertado());
                
                int devuelta = pag.Devuelta(precio_producto);
                int pesos = pag.Monto_insertado();
                if(devuelta < precio_producto){
                    Console.WriteLine("Usted inserto {0} pesos, faltan {1} para hacer su  compra", pesos, devuelta);
                    while(pesos < devuelta){
                        Console.WriteLine("Dinero insuficiente, ingrese mas dinero");
                        pag.insertar_Pago();
                        pesos = pag.Monto_insertado();
                    }
                }
                else if(devuelta > precio_producto){
                    Console.WriteLine("Ha usted le sobran {0} pesos, Retire su cambio",devuelta);
                }
                Console.WriteLine("Gracias por su compra");
                productos[9].existencia -= 1;
                }
                else{
                    Console.WriteLine("Lo sentimos no hay existencia del producto {0}", nombre_producto);
                }
                break;
                case 11:
                for(int i = 0; i < productos_orginal.Length; i++){
                    int existencia_original = productos_orginal[i].existencia;
                    int existencia_actual = productos[i].existencia;
                    int informe = existencia_original - existencia_actual;

                    if(existencia_actual != existencia_original){
                        Console.WriteLine("Se vendieron {0} {1} y quedaron {2}",informe, productos_orginal[i].nombre,existencia_actual);
                    }
                }
                break;
            }
            }while(va != 11);
        }
    }
}
