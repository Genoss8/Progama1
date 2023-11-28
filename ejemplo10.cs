using System;
					
public class Program
{
	public static void Main()
	{
		string articulo;
		double precio;
		int cantidad;
		double subtotal;
		double totPago;
		int tipoCambio;
		string eleccion;
		double dolar;
		Console.WriteLine("nombre de articulo a comprar");
		articulo= Console.ReadLine();
		Console.WriteLine("El precio del articulo es:");
		precio=double.Parse(Console.ReadLine());
		Console.WriteLine("La cantidad del mismo articulo es;");
		cantidad= int.Parse(Console.ReadLine());
		subtotal= precio * cantidad ;
		Console.WriteLine("Desea hacer el pago en dolares o en pesos?");
		Console.WriteLine("1-Pesos" );
		Console.WriteLine("2-Dolares" );
		tipoCambio= int.Parse(Console.ReadLine());
		switch(tipoCambio)
		{
			case 1:
				eleccion="Pesos";
				Console.WriteLine("Se agregara un IVA  del 10% ");
				totPago=subtotal+(subtotal * 0.10);
				Console.WriteLine("Su total a pagar en pesos es:" + totPago);
				break;
			case 2:
				eleccion="Dolares";
				dolar= subtotal/17.12;
				Console.WriteLine("Se le agregara un TAX del 8.25%");
				totPago=dolar+((8.25/100)*dolar);
				Console.WriteLine("El total a pagar en dolares es:"+totPago);
				break;
			default:
				Console.WriteLine("OPCION INCORRECTA");
				break;
					