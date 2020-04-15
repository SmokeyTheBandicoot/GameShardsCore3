using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Tree.BinaryTree {
    
    public abstract class IBinaryTree<T> : ITree<T> {

        /// <summary>
        /// Returns a Position representing Parent's left child
        /// </summary>
        /// <returns></returns>
        public abstract Position Left(Position Parent);

        /// <summary>
        /// Returns a Position representing Parent's right child
        /// </summary>
        /// <param name="Parent"></param>
        /// <returns></returns>
        public abstract Position Right(Position Parent);

        /// <summary>
        /// Returns a position representing sibling's sibling (or null if there is no sibling)
        /// </summary>
        /// <param name="Sibling"></param>
        /// <returns></returns>
        public Position Sibling(Position Sibling) {
            Position parent = GetParent(Sibling);
            if (parent == null) return null;
            else {
                if (Sibling == Left(parent)) return Right(parent);
                else return Left(parent);
            }
        }

        /// <summary>
        /// Generates an iteration on the Position representing Parent's children
        /// </summary>
        /// <param name="Parent"></param>
        /// <returns></returns>
        public override IEnumerable<Position> GetChildren(Position Parent) {
            if (Left(Parent) != null) yield return Left(Parent);
            if (Right(Parent) != null) yield return Right(Parent);
        }

        /// <summary>
        /// Generates an in-order iteration of the positions of the tree
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> InOrder() {
            if (!IsEmpty())
                foreach (Position p in SubtreeInorder(Root))
                    yield return p;
        }

        /// <summary>
        /// Generates an inorder iteration of positions in the subtree rooted at p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        protected IEnumerable<Position> SubtreeInorder(Position p) {
            if (Left(p) != null)
                foreach (Position other in SubtreeInorder(Left(p)))
                    yield return other;
            yield return p;
            if (Right(p) != null)
                foreach (Position other in SubtreeInorder(Right(p)))
                    yield return other;

        }

        /// <summary>
        /// Generates an iteration of the tree's positions, in-order
        /// </summary>
        /// <returns></returns>
        public new IEnumerable<Position> GetPositions() {
            return InOrder();
        }

    }

}
