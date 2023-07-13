using Opc.Ua.Client;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opc_ua_reader_test.Repositorys
{
    public class OpcReaderRepository
    {
        private static OpcReaderRepository instance;
        public static OpcReaderRepository Instance => instance ?? (instance = new OpcReaderRepository());//singelton instance

        public IList<object> CallMethodts(string url, string noteClassId, string noteId, params object[] args)
        {
            try
            {
                Console.WriteLine("Step 1 - Create application configuration and certificate.");
                var config = new ApplicationConfiguration()
                {
                    ApplicationName = "OpcReader",
                    ApplicationType = ApplicationType.Client,
                    SecurityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate = new CertificateIdentifier(),
                        AutoAcceptUntrustedCertificates = true,
                    },

                    ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },

                };

                config.Validate(ApplicationType.Client).GetAwaiter().GetResult();

                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
                }
                //ent point parametreye alınacak
                var selectedEndpoint = CoreClientUtils.SelectEndpoint(url, useSecurity: false);

                Console.WriteLine($"Step 2 - Create a session with your server: {selectedEndpoint.EndpointUrl} ");
                using (var session = Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 60000, null, null).GetAwaiter().GetResult())
                {
                    Console.WriteLine("Step 3 - Browse the server namespace.");
                    ReferenceDescriptionCollection refs;
                    Byte[] cp;
                    session.Browse(null, null, ObjectIds.ObjectsFolder, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out cp, out refs);

                    Console.WriteLine("Sesion Call Methods");

                    IList<object> vals = session.Call(
                        new NodeId(noteClassId),
                        new NodeId(noteId),
                        args
                        );
                    return vals;
                }

            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
