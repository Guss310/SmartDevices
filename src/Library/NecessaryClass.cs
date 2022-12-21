using AdapterExample; 
namespace NecessaryClass;
/// <summary>
/// Adaptador de Plug a un SmartDevice
/// </summary>
public class driver : ISmartDevice
{
    /// <summary>
    /// Crea un adaptador
    /// </summary>
    /// <param name="plug">el plug para adaptar</param>
    public driver(Plug plug)
    {
        this.PlugDriver = plug;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Plug PlugDriver { get; set; }

    /// <summary>
    /// Enciende el dispositivo si está apagado
    /// </summary>

    public void On()
    {
        if (PlugDriver.GetStatus() == "off")
        {
            PlugDriver.ToggleStatus();
        }
    }
   
    /// <summary>
    ///  Apaga el dispositivo cuando está prendido
    /// </summary>
    
    public void Off()
    {
        if (PlugDriver.GetStatus() == "on")
        {
            PlugDriver.ToggleStatus();
        }
    }

    /// <summary>
    /// Devuelve el registro del estado del dispositivo
    /// </summary>
    /// <returns></returns>
        public string GetStatus()
    {
        return PlugDriver.GetStatus();
    }
}