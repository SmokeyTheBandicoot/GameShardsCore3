using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameShardsCore3.ResourceManager {


    /// <summary>
    /// Main registry class. Contains a reference to all the values associated with a 
    /// key (string). Type of value is generic.
    /// Can be used to create TexturePacks, LanguagePacks, SoundPacks and so on
    /// 
    /// <example>If this is used as a language registry (pseudocode):
    /// ResourceRegistry(of string) LanguageRegistry = new ResourceRegistry(of string)
    /// ResourceEntry(of string) Items = new ResourceEntry(of string);
    /// Items.REntry.Add("IT_it", "Colore rosso");
    /// Items.REntry.Add("EN_us", "Red color");
    /// Items.REntry.Add("EN_uk", "Red colour");
    /// LanguageRegistry.RegisterEntry("color_red", Items);
    /// LanguageRegistry.CurrentResourceSet = "IT_it";
    /// LanguageRegistry.GetResource("color_red");
    /// //Returns "Colore rosso"
    /// 
    /// LanguageRegistry.CurrentResourceSet = "EN_us";
    /// LanguageRegistry.GetResource("color_red");
    /// //Returns "Red color"
    /// </example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class ResourceRegistry<T>{

        public Dictionary<string, ResourceEntry<T>> Registry { get; }
        public string CurrentSet { get; set; }

        /// <summary>
        /// Register a new entry. 
        /// </summary>
        /// <param name="Key">Key to register (I.E.: unlocalized entry)</param>
        /// <param name="Entry"></param>
        /// <returns></returns>
        public bool RegisterEntry(string Key, ResourceEntry<T> Entry) {

            //Cannot add a value in a null key
            if (Key == null) return false;

            //Cannot add a null value
            if (Entry == null) return false;

            //Value already contained
            if (Registry.ContainsKey(Key))
                return false;

            //Successfully add the key
            Registry.Add(Key, Entry);
            return true;
        }

        /// <summary>
        /// Replaces an entry with a new one
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="NewEntry"></param>
        /// <returns></returns>
        public ResourceEntry<T> ReplaceEntry(string Key, ResourceEntry<T> NewEntry) {

            //If registry does not contain the key, simply register it and return null
            if (!Registry.ContainsKey(Key)) {
                RegisterEntry(Key, NewEntry);
                return null;
            }

            //else retrieve the previous entry, remove it and register the new one. Finally return the previous one
            ResourceEntry<T> temp = Registry[Key];
            Registry.Remove(Key);
            RegisterEntry(Key, NewEntry);
            return temp;

        }

        /// <summary>
        /// Gets the specified resource. This should be the main method of retrieving a resource
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="ResourceSet"></param>
        /// <param name="ThrowExceptions"></param>
        /// <returns></returns>
        public T GetResource(string Key, string ResourceSet, bool ThrowExceptions = false) {

            //If key is null, throw exception
            if (Key == null) throw new ArgumentNullException("Key is null");

            //If key is not contained, then throw exception
            if (!Registry.ContainsKey(Key)) throw new ArgumentException("Key is not contained in the current registry");

            //Seraching a null keyset (no language specified, for example): throw exception
            if (ResourceSet == null) throw new ArgumentNullException("Resource set is null");

            //If key is contained in the registry, but not in the set, then something might have gone wrong in the registry building
            //If the Registry is a registry of string (I.E.: Language Registry) then try to return the unlocalized string, if ThrowException is false
            if (!Registry[Key].REntry.ContainsKey(ResourceSet)) {
                if (ThrowExceptions) {
                    throw new ArgumentException("Key is contained in the registry, but not in the current set");
                }
                else {

                    //If this is a registry of strings
                    if (typeof(T) == typeof(string)) {

                        //Call the constructor of string (Char[] chars)
                        //THIS WILL NOT WORK FOR ALL THE TYPES! but since this code is string-specific, this should be safe
                        //as long as Microsoft does not depreciate/remove this string constructor. 
                        //This line of code is used to return a string as a T type
                        return (T)Activator.CreateInstance(typeof(T), Key.ToCharArray());
                    }
                }
            }

            return Registry[Key].REntry[ResourceSet];

        }

        /// <summary>
        /// Loads a registry from file using the ISerializable interface
        /// </summary>
        /// <param name="path"></param>
        public void FromSerializedFile(string path) {

        }

        


    }

}
