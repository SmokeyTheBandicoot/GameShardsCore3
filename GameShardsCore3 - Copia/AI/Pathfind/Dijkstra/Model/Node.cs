using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.Model { 

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    /// <summary>
    /// Represents a graph Node. Probably will became an interface to be applicable on various classes
    /// </summary>
    public class Node : IEquatable<Node> {

        public string ID { get; set; }
        public string Name { get; set; }

        public Node(string ID, string Name) {
            this.ID = ID;
            this.Name = Name;
        }

        public override bool Equals(object obj) {

            if (this == obj) {
                return true;
            }

            if (obj == null) {
                return false;
            }

            if (this.GetType() != obj.GetType()) {
                return false;
            }

            Node Other = (Node)obj;

            if (Other == null) {
                return false;
            }

            if (ID == null) {
                if (Other.ID != null) {
                    return false;
                }
            }
            else if (!ID.Equals(Other.ID)) {
                return false;
            }

            return true;
        }

        public override string ToString() {
            return Name;
        }

        public bool Equals(Node other) {
            return other != null &&
                   ID == other.ID &&
                   Name == other.Name;
        }

        public override int GetHashCode() {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public static bool operator ==(Node node1, Node node2) {
            return EqualityComparer<Node>.Default.Equals(node1, node2);
        }

        public static bool operator !=(Node node1, Node node2) {
            return !(node1 == node2);
        }
    }
}
