﻿using System;
// 1. add reference PluginInterface
using PluginInterface;


namespace Plugin6
{
    //2 add base class IPlugin
    public class Plugin : IPlugin  
    {
        public Plugin()
        { 
        
        // constructor
        
        }


    // 4 add and initials member variables
    string myName = "Plugin6";
    string myDescription = "A Simple Text Editor. Very Simple!";
    string myAuthor = "Jon Dick";
    string myVersion = "1.0.0";
    IPluginHost myHost = null;
   // System.Windows.Forms.UserControl myMainInterface = new ctlMain();
    System.Windows.Forms.UserControl myMainInterface = new ctlMain();


     /* 5 add implementation
      * 
      * 'PluginInterface.IPlugin.Initialize()'
      * 'PluginInterface.IPlugin.Dispose()'
      * 'PluginInterface.IPlugin.Host'
      * 'PluginInterface.IPlugin.Name'
      * 'PluginInterface.IPlugin.Description'
      * 'PluginInterface.IPlugin.Author'
      * 'PluginInterface.IPlugin.Version'
      * 'PluginInterface.IPlugin.MainInterface'
      */
    public string Description
    {
        get { return myDescription; }
    }

    /// <summary>
    /// Author of the plugin
    /// </summary>
    public string Author
    {
        get { return myAuthor; }

    }

    /// <summary>
    /// Host of the plugin.
    /// </summary>
    public IPluginHost Host
    {
        //This part is currently not really implemented
        /*
        Here's the scoop though... You can make the host program
        Implement this interface... this essentially gives you the ability
        to allow plugins to access some functionality of the host program.
			
        Example: an mp3 player.  If you had the IPluginHost interface as like:
			
        public interface IPluginHost
        {
            void Play(string FileName);
            void Stop();			
        }
			
        what you would do is when the plugin is loaded in the host (this would be
        in like the PluginServices.cs file in the AddPlugin() method) you would 
        set:
            newPlugin.Host = this;
				
        this would give the plugin a reference to the host... now since the plugin
        knows the host contains these methods, it can easily access them just like:
			
            this.Host.Play("C:\MyCoolMp3.mp3");
				
        and then they could go:
			
            this.Host.Stop();
				
        all this being from right inside the plugin!  I hope you get the point.  It 
        just means that you can indeed make your plugins able to interact with the 
        host program itself.  Let's face it.. It would be no fun if you couldn't do this,
        because otherwise all the plugin is, is just standalone functionality running
        inside the host program.. (of course there are cases when you can still accomplish
        many things without needing to allow the plugin to play with the host... for example
        you could have an spam filter, and have each plugin be a different filter... that would
        be pretty simple to make plugins for...
			
        so anyhow, that is what the host thingy is all aboot, eh!	
			
        */
        get { return myHost; }
        set { myHost = value; }
    }

    public string Name
    {
        get { return myName; }
    }
    public string Version
    {
        get { return myVersion; }
    }

    public void Initialize()
    {
        //This is the first Function called by the host...
        //Put anything needed to start with here first
    }

    public void Dispose()
    {
        //Put any cleanup code in here for when the program is stopped
    }
    public System.Windows.Forms.UserControl MainInterface
    {
        get { return myMainInterface; }
    }

    
    }

}