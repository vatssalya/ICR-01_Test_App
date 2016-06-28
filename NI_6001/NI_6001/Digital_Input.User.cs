// Use this file to enhance and extend the component generated by the DAQ Assistant.
// 
// Refer to "Adding Custom Functionality to a .NET DAQ Component" in the NI Measurement Studio Help for more
// information.
// 
// This file is never regenerated by the DAQ Assistant, so any changes you make here will not be overwritten
// if you modify your DAQmx task with the DAQ Assistant configuration editor.

using System;
using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.DAQmx.ComponentModel;

namespace NI_6001
{
    // This partial class extends the class defined by the DAQ Assistant in Digital_Input.cs
    public partial class Digital_InputComponent
    {
        /// <summary>
        /// Initializes a new instance of the component.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            // TODO: Perform custom initialization here.
            //       This method is called when the component is created.
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources need to be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // TODO: Perform custom clean-up here.
            //       
            //       Refer to "Implementing a Dispose Method" in the .NET Framework documentation for more
            //       information on the Disposable Pattern.

            if (disposing)
            {
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Raises the TaskCreated event.
        /// </summary><param name="e">
        /// The event arguments of the TaskCreated event.
        /// </param>
        protected override void OnTaskCreated(EventArgs e)
        {
            // TODO: Perform custom DAQmx task configuration, such as advanced timing and triggering, here.
            //       
            //       Refer to "Adding Custom Functionality to a .NET DAQ Component" in the NI Measurement
            //       Studio Help for an example of advanced DAQmx task configuration.

            base.OnTaskCreated(e);
        }
    }
}
