//------------------------------------------------------------------------------
// <autogenerated>
//    This code was generated by Measurement Studio.
//    Runtime Version: 15.0.0.49153
//
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// <autogenerated>
//------------------------------------------------------------------------------

using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.DAQmx.ComponentModel;
using System;
using System.ComponentModel;
using System.Threading;


namespace NI_6001
{
    /// <summary>
    /// Defines a DAQ component that performs finite input data acquisition
    /// operations.
    /// </summary>
    [System.ComponentModel.DesignerCategory("Code")]
    [ToolboxItem(false)]
    [TemplateData("ReadWfm", MxbFile="AI3.mxb")]
    partial class AI3Component : FiniteInputDaqComponent<AnalogMultiChannelReader, AnalogWaveform<double>[]>
    {
        private static readonly object EventReadCompleted = new object();
        private const int DefaultNumberOfSamplesToRead = -1;
        private static readonly TimeSpan DefaultTimeout = TimeSpan.FromMilliseconds(10000);
        
        /// <summary>
        /// Initializes a new instance of the component.
        /// </summary>
        public AI3Component()
        {
            Initialize();
        }
        
        /// <summary>
        /// Initializes a new instance of the component with the specified container.
        /// </summary>
        public AI3Component(IContainer container)
            : this()
        {
            if (container != null)
                container.Add(this);
        }
        
        /// <summary>
        /// Creates the underlying DAQ task of the component.
        /// </summary><returns>
        /// A DAQ task that represents the DAQ task of the component.
        /// </returns>
        protected override Task CreateTask()
        {
            AI3 newTask = new AI3();
            newTask.Stream.Timeout = Convert.ToInt32(DefaultTimeout.TotalMilliseconds);
            return newTask;
        }

        /// <summary>
        /// Creates the underlying DAQ reader of the component.
        /// </summary><returns>
        /// The DAQ reader that performs the input data acquisition operations.
        /// </returns>
        protected override AnalogMultiChannelReader CreateReader()
        {
            return new AnalogMultiChannelReader(Task.Stream);
        }

        /// <summary>
        /// Performs a synchronous read operation with the specified number of
        /// samples to read and returns the acquired data.
        /// </summary><param name="numberOfSamplesToRead">
        /// The number of samples to read in the synchronous read data acquisition.
        /// </param><returns>
        /// A value that contains the result of the synchronous read operation.
        /// </returns>
        public AnalogWaveform<double>[] Read(int numberOfSamplesToRead)
        {
            bool taskAutoStarted = false;

            if (!IsTaskStarted)
            {
                StartTask();
                taskAutoStarted = true;
            }

            AnalogWaveform<double>[] data = ReadFinite(numberOfSamplesToRead);

            if (taskAutoStarted)
                StopTask();

            return data;
        }

        /// <summary>
        /// Performs a synchronous read operation.
        /// </summary><returns>
        /// A value that contains the result of the synchronous read operation.
        /// </returns>
        protected override AnalogWaveform<double>[] ReadFinite()
        {
            return ReadFinite(DefaultNumberOfSamplesToRead);
        }

        private AnalogWaveform<double>[] ReadFinite(int numberOfSamplesToRead)
        {
            return Reader.ReadWaveform(numberOfSamplesToRead);
        }
        
        /// <summary>
        /// Begins an asynchronous read operation.
        /// </summary><param name="callback">
        /// An asynchronous callback that is called when the read is completed.
        /// </param><param name="state">
        /// An object that distinguishes this asynchronous read request from other
        /// requests.
        /// </param>
        protected override void BeginReadFinite(AsyncCallback callback, object state)
        {
            Reader.BeginReadWaveform(DefaultNumberOfSamplesToRead, callback, state);
        }

        /// <summary>
        /// Ends an asynchronous read operation.
        /// </summary><param name="result">
        /// An IAsyncResult that represents an asynchronous call started by
        /// BeginReadFinite.
        /// </param>
        protected override void EndReadFinite(IAsyncResult result)
        {
            try
            {
                AnalogWaveform<double>[] data = Reader.EndReadWaveform(result);

                AI3ComponentReadCompletedEventArgs args = new AI3ComponentReadCompletedEventArgs(data);
                RaiseGenericEventAsync(result, OnReadCompleted, args);
            }

            #region Debugger Exception Warnings
            catch (DaqException ex)
            {
                // If you Dispose the component while an asynchronous DAQ operation
                // is still running, the component may already be disposed or may be in the
                // process of disposing when this method is called.  Depending on timing, this situation
                // will result in one of the three errors below.  This is expected behavior.
                //
                // DaqExceptions are processed by the caller of this method in the
                // NationalInstruments.DAQmx.ComponentModel class library.  However, by default,
                // the Visual Studio debugger intercepts these exceptions and breaks
                // the debugger when they occur.
                //
                // Because these exceptions do not represent errors, they are caught and safely discarded
                // here.
                if (ex.Error != -200088 && ex.Error != -88709 && ex.Error != -88710)
                    throw;
            }
            #endregion

        }

        /// <summary>
        /// Raises the ReadCompleted event.
        /// </summary><param name="e">
        /// The event arguments of the ReadCompleted event.
        /// </param>
        protected virtual void OnReadCompleted(AI3ComponentReadCompletedEventArgs e)
        {
            RaiseGenericEventDirect(EventReadCompleted, e);
        }

        /// <summary>
        /// Occurs when the asynchronous read operation that was initiated by
        /// ReadAsync has completed.
        /// </summary>
        [Category("Action")]
        [Description("Occurs when the asynchronous read operation that was initiated by ReadAsync has completed.")]
        public event EventHandler<AI3ComponentReadCompletedEventArgs> ReadCompleted
        {
            add
            {
                AddEventHandler(EventReadCompleted, value);
            }

            remove
            {
                RemoveEventHandler(EventReadCompleted, value);
            }
        }
    }

    /// <summary>
    /// Provides data for the ReadCompleted event.
    /// </summary>
    public class AI3ComponentReadCompletedEventArgs : ReadCompletedEventArgs<AnalogWaveform<double>[]>
    {
        /// <summary>
        /// Initializes a new instance of the ReadCompleted event arguments.
        /// </summary><param name="data">
        /// The data that was acquired from an asynchronous finite input data acquisition.
        /// </param>
        public AI3ComponentReadCompletedEventArgs(AnalogWaveform<double>[] data)
            : base(data)
        {
        }
    }

    #region Timing Compatibility
    partial class AI3Component
    {
        /// <summary>
        /// This member supports compatibility with code that is generated with a
        /// different timing mode and is not intended to be used directly from your code.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member supports compatibility with code that is generated with a different timing mode and is not intended to be used directly from your code.")]
        public event EventHandler<AI3ComponentDataReadyEventArgs> DataReady
        {
            add
            {
                throw new NotSupportedException("This member supports compatibility with code that is generated with a different timing mode and is not intended to be used directly from your code.");
            }

            remove
            {
                throw new NotSupportedException("This member supports compatibility with code that is generated with a different timing mode and is not intended to be used directly from your code.");
            }
        }
    }
    
    /// <summary>
    /// This type supports compatibility with code that is generated with a
    /// different timing mode and is not intended to be used directly from your code.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class AI3ComponentDataReadyEventArgs : DataReadyEventArgs<object>
    {
        /// <summary>
        /// This member supports compatibility with code that is generated with a
        /// different timing mode and is not intended to be used directly from your code.
        /// </summary>
        public AI3ComponentDataReadyEventArgs(object data)
            : base(data)
        {
            throw new NotSupportedException("This member supports compatibility with code that is generated with a different timing mode and is not intended to be used directly from your code.");
        }
    }
    #endregion




      
    public class AI3 : Task
    {
        public AI3()
        {
            Configure();
        }
        
        public virtual void Configure()
        {
            // This code was generated by Measurement Studio.  Changes to this 
            // file may cause incorrect behavior and will be lost if the code 
            // is regenerated.
            
                AIChannels.CreateVoltageChannel("Dev1/ai3", "Voltage", AITerminalConfiguration.Differential, -10, 10, AIVoltageUnits.Volts);
                Timing.ConfigureSampleClock("", 1000, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, 100);

        }
    }


}
