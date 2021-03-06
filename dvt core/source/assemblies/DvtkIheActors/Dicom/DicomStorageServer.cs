// Part of DvtkIheActors.dll - .NET class library providing basic data-classes for DVTK
// Copyright � 2001-2006
// Philips Medical Systems NL B.V., Agfa-Gevaert N.V.

using System;
using DvtkHighLevelInterface;
using DvtkHighLevelInterface.Messages;
using DvtkHighLevelInterface.InformationEntity;
using Dvtk.DvtkDicomEmulators.StorageClientServers;
using Dvtk.DvtkDicomEmulators.StorageMessageHandlers;

namespace Dvtk.IheActors.Dicom
{
	/// <summary>
	/// Summary description for DicomStorageServer.
	/// </summary>
	public class DicomStorageServer : DicomServer
	{
		public DicomStorageServer(BaseActor parentActor, ActorNameEnum actorName) : base (parentActor, actorName) {}

		public override void ApplyConfig(DicomConfig config)
		{
			// set up the Query/Retrieve information models
			QueryRetrieveInformationModels informationModels = new QueryRetrieveInformationModels();

			// load the information models
			informationModels.Load(config.DataDirectory);

			// add any default attribute values to the information models
			informationModels.AddDefaultAttribute("0x00080005", DvtkData.Dimse.VR.CS, "ISO IR 6");
			informationModels.AddDefaultAttribute("0x00080090", DvtkData.Dimse.VR.PN, "Referring^Physician^Dr");

			// set up the storage SCP
			StorageScp storageScp = new StorageScp();
			Scp = storageScp;

			// apply the remaining configuration
			base.ApplyConfig(config);

			// add the default message handlers with the information models
			storageScp.AddDefaultMessageHandlers(informationModels);
		}

		public override void AssociationReleasedEventHandler(DicomThread storageScp)
		{
			// do SCP specific post association processing here

			// call base implementation to generate event, update transaction log and cleanup data warehouse
			base.AssociationReleasedEventHandler(storageScp);
		}
	}
}
