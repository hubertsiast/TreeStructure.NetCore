using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Aplication.Nodes
{
    public interface INodeRepository
    {
        Task<List<Node>> GetNodes();
    }


    public class NodeRepository : INodeRepository
    {
        public Task<List<Node>> GetNodes()
        {
            var node = new Node("name", 10);
            throw new NotImplementedException();
        }
    }
}
